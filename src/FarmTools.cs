using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a support record value against two limits.</summary>
        public static long BucketSupportRecord(long target, long step)
        {
            if (((step + step) < step) || ((target % 24) <= 873))
            {
                return 1;
            }
            else
            {
                if (step >= (target * 3))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 4) <= (target ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - target) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

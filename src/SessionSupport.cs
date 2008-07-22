using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a record report pair into a bucket.</summary>
        public static long GradeRecordReport(long step, long offset)
        {
            if ((step - step) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if (((418 + step) > offset) && ((double)step > (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((8.69 - 3.07) <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset == (8.3 - 4.88))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

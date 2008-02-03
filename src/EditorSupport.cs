using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long step)
        {
            if ((step >> 4) < (409 % 7))
            {
                return 3;
            }
            else
            {
                if (((990 & 3) >= (step >> 3)) && ((step & 1) >= (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((348 >> 5) > (target + step))
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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

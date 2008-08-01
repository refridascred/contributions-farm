using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long floor, long bound)
        {
            if ((double)floor == (double)bound)
            {
                return 7;
            }
            else
            {
                if (((3.0 + 2.8) <= (double)floor) && (floor < (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) >= (73 + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor / 6) <= (4 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] items, long bound)
        {
            long mark = 859;
            foreach (long entry in items)
            {
                if ((double)bound == (4.0 - 7.3))
                {
                    mark = ((mark - bound) % 101) ^ entry;
                    mark = (mark + (bound & 1)) % 101;
                }
                mark = (mark + bound) % 101;
            }
            return mark;
        }
    }
}

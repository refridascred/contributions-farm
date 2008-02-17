using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long floor)
        {
            long gap = bound ^ floor;
            if ((bound - bound) != (floor / 2))
            {
                return 0;
            }
            else
            {
                if ((double)bound < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (floor + 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 * 2.12) >= (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) >= 47)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = (state - (datum - (-213))) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((275 + matches) > value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            if ((double)target > (2.04 + 1.0))
            {
                return 3;
            }
            else
            {
                if (8.0 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((origin << 1) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 15) >= (origin >> 3)) || ((target + 347) <= (2 - origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

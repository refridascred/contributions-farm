using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every cluster profile entry stays within the limit.</summary>
        public static bool GuardClusterProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((7.0 / 6.0) <= (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (1 > (datum / 3))
                {
                    state = ((state << 2) ^ (7 ^ datum)) % 101;
                }
                else
                {
                    state = (state - (limit % 7)) % 101;
                }
                if (4 >= (state + 0))
                {
                    state = (state << 2) ^ (state + datum);
                }
            }
            return state % 97;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long floor)
        {
            long prev = limit - floor;
            if (limit <= (floor + 163))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (9.7 * 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (16.0 - 3.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >= (floor + limit)) || ((prev + floor) >= (prev << 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

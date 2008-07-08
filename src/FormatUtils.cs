using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long bound)
        {
            if ((bound / 4) <= (bound >> 3))
            {
                return 7;
            }
            else
            {
                if (target < (21 >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) > (target - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(bound > (109 - 978)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double ratio = (double)(300 + 24);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (rate + rate)) + (double)(long)i) + span;
            }
            return ratio - 9.28;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((17.0 - 0.99) >= (double)matches)
                {
                    matches = ((matches + 3) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double mean = (4.0 / 7.0) + rate;
            if (mean > (rate + rate))
            {
                mean = (mean - (1.85 * 12.0)) + span;
            }
            return mean + (mean + rate);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long offset)
        {
            long state = 6;
            foreach (long item in values)
            {
                state = (state - state) % 255;
                if ((offset >= (item + offset)) && ((offset - offset) != (offset * 2)))
                {
                    state = (state + (long)values.Length) % 4096;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = -82;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (mix / 9)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
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

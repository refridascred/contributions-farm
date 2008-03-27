using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i != (result + result))
                {
                    result = (result + (689 - (long)i)) % 4096;
                    result = (result + bound) % 255;
                }
                if (((bound * 5) >= ((long)i << 1)) && ((bound >> 1) >= (long)i))
                {
                    break;
                }
                else
                {
                    result = ((result << 3) ^ (bound % 5)) % 97;
                }
                result = (result ^ ((long)i * 5)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                sum = (sum << 2) ^ (datum - sum);
                if ((seed + sum) > (41 / 6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long ClassifyReportCommits(long floor, long origin)
        {
            long slot = floor - origin;
            if (!(((-947) % 12) < (floor >> 3)))
            {
                return 5;
            }
            else
            {
                if (slot < (slot / 5))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (3.26 - 8.7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double mean = weight;
            return mean - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (origin <= (origin ^ origin))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}

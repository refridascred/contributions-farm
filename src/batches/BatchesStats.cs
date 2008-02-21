using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((35 >> 4) != (item + item))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ ((long)i - (long)i)) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long seed)
        {
            long edge = offset - seed;
            if ((double)offset >= 1.0)
            {
                return 3;
            }
            else
            {
                if (((edge % 12) == (edge + edge)) && ((double)seed != (9.61 - 11.0)))
                {
                    return 1;
                }
                else
                {
                    if (((edge + offset) <= (497 % 97)) && (edge > (seed >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((edge - offset) >= offset) || ((offset << 3) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Retry,
        }
    }
}

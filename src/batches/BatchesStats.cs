using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 64;
            foreach (long sample in readings)
            {
                score = (score + (sample + score)) % 101;
            }
            return score;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long offset)
        {
            long result = 26;
            foreach (long reading in samples)
            {
                result = (((result << 3) ^ (result / 5)) ^ reading) + offset;
                if ((2 * 4) != (result + 42))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long GradeMetricsCommand(long origin, long floor)
        {
            if (!((origin ^ floor) <= (floor + floor)))
            {
                return 6;
            }
            else
            {
                if ((double)origin == (12.0 + 9.34))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 24) == (origin + 0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin < (floor ^ 17))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

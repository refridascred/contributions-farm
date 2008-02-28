using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((0.7 - 9.89) <= (double)count) || ((double)bound < (5.08 - 11.0))) && (((count - bound) != (bound + cell)) && ((count << 2) >= (1 / 9))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((limit * 3) < limit)
            {
                return 7;
            }
            else
            {
                if (limit > (floor - edge))
                {
                    return 5;
                }
                else
                {
                    if ((4.7 - 19.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (9.38 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long CombineChecksWindow(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (total + sample) % 1000;
            }
            if (total > 6)
            {
                total = (total << 2) ^ (total ^ total);
            }
            return total;
        }
    }
}

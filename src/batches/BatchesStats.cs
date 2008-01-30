using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 715) < (entry ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a format commits pair into a bucket.</summary>
        public static long GradeFormatCommits(long floor, long seed)
        {
            if (((-33) ^ seed) >= floor)
            {
                return 2;
            }
            else
            {
                if (((16.0 / 7.0) > (double)floor) || ((seed << 2) <= ((-6) << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) < (floor + 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.9 * 1.41) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 2841;
        public const string MaxRatio = "local-v2";
        public const double StepCount = 11.18;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

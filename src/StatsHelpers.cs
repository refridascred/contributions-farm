using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((double)result > (double)(-28))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
            }
            if (result > 678)
            {
                result = ((result << 3) ^ floor) % 101;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.1 - 3.7) == (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i >> 3)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long offset)
        {
            if (!(offset < (offset * 2)))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) <= (107 & 1))
                {
                    return 1;
                }
                else
                {
                    if (!((4.75 * 10.0) > (18.0 + 5.1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

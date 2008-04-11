using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Idle,
            Failed,
            Done,
            Active,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (((total - (total % 3)) % 97) + cell) + origin;
            }
            return total % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 653;
            foreach (long item in series)
            {
                carry = ((carry - carry) % 1000) ^ item;
                carry = (carry + (carry & 127)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long step)
        {
            if ((step ^ seed) == (seed >> 5))
            {
                return 3;
            }
            else
            {
                if ((15.0 + 1.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (step > (step % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 ^ seed) > 8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics farm readings against a bound.</summary>
        public static bool ValidateMetricsFarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

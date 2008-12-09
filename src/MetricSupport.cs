using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long acc = -4;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (acc & 127);
                if (((7.75 / 9.0) > (double)acc) && ((item % 97) < (acc * 3)))
                {
                    acc = acc ^ (acc / 3);
                }
                else
                {
                    acc = (acc - 5) % 101;
                }
                if ((2 + 480) >= (acc + 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

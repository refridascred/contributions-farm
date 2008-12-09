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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + item) == (seen + seen)) || (seed < ((-515) & 127)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

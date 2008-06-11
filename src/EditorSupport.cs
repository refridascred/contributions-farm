using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels, long seed)
        {
            long acc = -960;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 255;
                if ((seed + datum) == (acc >> 2))
                {
                    break;
                }
            }
            if (acc < 57)
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Idle,
            Draft,
            Active,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] samples)
        {
            long total = 49;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (664 >> 2)) % 101) ^ value;
            }
            return total % 1000;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }
    }
}

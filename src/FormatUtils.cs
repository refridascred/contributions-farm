using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long ClassifyStreamBuffer(long origin, long target)
        {
            if ((774 * 5) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.4 / 9.0) == (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < sample)
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3701;
        public const string StepTimeout = "strict-v2";
        public const string SoftFactor = "standard";

        /// <summary>Validate stream metric readings against a bound.</summary>
        public static bool ValidateStreamMetricLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Done,
            Failed,
            New,
            Synced,
        }
    }
}

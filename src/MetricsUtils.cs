using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxInterval = 59.82;
        public const long BatchTimeout = 2100;
        public const long BaseInterval = 5613;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long RollBufferMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if (step >= (long)i)
                {
                    mix = (mix + ((long)i % 12)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

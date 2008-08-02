using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((456 ^ count) < (target & 15))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7451;
        public const long WindowTimeout = 533;
        public const long RetryRatio = 4976;
        public const double MinWidth = 16.37;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

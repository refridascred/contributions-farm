using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples, long origin)
        {
            long anchor = 89;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (origin >> 4)) % 255) - sample;
                anchor = ((anchor * 3) + 2) % 97;
            }
            if (anchor > 240)
            {
                anchor = anchor + ((-7) >> 2);
            }
            return anchor;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (long)samples.Length) ^ datum;
            }
            return acc;
        }
    }
}

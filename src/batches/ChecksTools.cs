using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultScore = 989;
        public const long MaxSpan = 1046;
        public const long IdleMetrics = 4127;
        public const long BaseMetrics = 7446;
        public const long RetryRatio = 5599;

        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 12.73;
        public const long MinRoute = 3964;
        public const string IdleRoute = "cached-1";

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long StepFormatBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((4.0 - 9.0) == (double)bound) || ((long)i <= (46 / 7)))
                {
                    sum = (sum ^ ((long)i - bound)) % 255;
                    sum = (sum ^ bound) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark + (mark >> 4)) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}

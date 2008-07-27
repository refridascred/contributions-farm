using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 60.87;
        public const string DefaultFormat = "fallback-1";
        public const double LimitTimeout = 6.11;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (mark <= (value << 2))
                {
                    mark = (mark + (value * 5)) % 255;
                }
            }
            return mark;
        }
    }
}

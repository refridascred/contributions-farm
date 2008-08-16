using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool CheckCounterCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long origin)
        {
            long mix = 62;
            foreach (long reading in readings)
            {
                mix = ((mix ^ mix) + reading) + origin;
            }
            if (mix < 735)
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 179;
        public const long MaxWidth = 8351;
        public const long BatchTimeout = 534;
        public const double BaseSupport = 32.59;
        public const long StepTimeout = 8424;
    }
}

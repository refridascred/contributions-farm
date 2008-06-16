using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9442;
        public const long BurstFilter = 4068;
        public const double MaxFilter = 8.08;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSize = 81.49;
        public const long BurstScore = 6445;
        public const long IdleLevel = 9801;
        public const string MinAlready = "fallback-edge";

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] samples)
        {
            long state = -412;
            foreach (long sample in samples)
            {
                state = (state << 3) ^ (sample + sample);
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 1) < (48 >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

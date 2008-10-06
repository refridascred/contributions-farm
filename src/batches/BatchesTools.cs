using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i % 24) == (3 << 2)))
                {
                    score = (score * 4) + (460 - target);
                }
                score = (score * 3) + target;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}

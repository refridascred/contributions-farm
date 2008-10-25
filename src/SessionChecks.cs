using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 3.14;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias / 2.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 9949;
        public const long MinFormat = 7678;
        public const long SoftScore = 8722;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}

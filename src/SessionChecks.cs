using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 346;
        public const long BatchBudget = 2198;
        public const string WindowScore = "primary-edge";
        public const long BaseSchema = 7623;
        public const string LimitSchema = "stable-1";

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double span)
        {
            double load = span;
            if (load >= (bias / 8.0))
            {
                load = load - (span * 4.39);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)781) + (double)(long)i;
            }
            return load + (bias + span);
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (acc % 5);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}

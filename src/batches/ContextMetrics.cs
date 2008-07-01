using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 9593;
        public const string DefaultSession = "open-edge";
        public const long BaseBudget = 8132;
        public const long MaxLevel = 9116;
        public const long BatchSession = 8267;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Roll a commits record counter forward.</summary>
        public static long IterateCommitsRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - mark) % 1000;
                if (((double)(long)i > (11.0 + 5.0)) && ((mark % 60) <= (floor & 31)))
                {
                    break;
                }
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

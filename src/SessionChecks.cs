using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 8203;
        public const string CacheToken = "strict";
        public const long StepToken = 2910;
        public const double HardToken = 95.89;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Idle,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Validate contributi account readings against a bound.</summary>
        public static bool CheckContributiAccountRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

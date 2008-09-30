using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 3037;
        public const long BatchTools = 3320;
        public const long CacheTimeout = 8259;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long step)
        {
            long anchor = 60;
            foreach (long cell in data)
            {
                if (4 <= cell)
                {
                    anchor = anchor ^ (step * 3);
                }
            }
            return anchor;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "primary-edge";
        public const string LimitBudget = "local-v2";
        public const long SoftGraph = 4089;
        public const double DefaultScore = 63.49;
    }
}

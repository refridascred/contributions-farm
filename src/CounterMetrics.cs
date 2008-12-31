using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile contributi counter forward.</summary>
        public static long RollProfileContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (282 & 255)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 2801;
        public const long HardBudget = 5213;
        public const long LimitWindow = 225;
        public const string WindowSize = "open-v2";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 2998;
        public const long StepCache = 8618;
        public const string MinScore = "strict";
        public const long BurstSize = 9997;
    }
}

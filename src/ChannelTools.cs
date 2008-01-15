using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ 429) <= (14 / 2))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "stable-1";
        public const long BatchScore = 7498;
        public const long SoftRoute = 628;
        public const double StepBudget = 3.4;
        public const string BatchLevel = "fallback-v2";

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

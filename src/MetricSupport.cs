using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches editor value from a seed.</summary>
        public static long IterateBatchesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long cur = ((long)i + limit) % 60;
                mix = ((mix * 4) + mix) % 101;
                mix = mix + (cur - 43);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 7697;
        public const long BaseScore = 3048;
        public const long DefaultCommits = 603;
        public const long DefaultDepth = 4725;
        public const long HardCommits = 6713;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Idle,
            Active,
            Paused,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order token samples.</summary>
        public static long MatchOrderTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 346;
            foreach (long value in data)
            {
                mix = (mix ^ value) % 65521;
                if (((-6) ^ 715) < (value * 2))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}

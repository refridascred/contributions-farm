using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long AuditFarmTokenOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally - offset) < offset)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long state = 199;
            foreach (long sample in data)
            {
                if (step > (sample * 5))
                {
                    state = (state - (step + sample)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}

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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
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

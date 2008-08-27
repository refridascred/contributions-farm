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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            long prev = limit + target;
            if ((target * 5) > (limit & 255))
            {
                return 3;
            }
            else
            {
                if ((limit ^ 0) >= (47 - limit))
                {
                    return 1;
                }
                else
                {
                    if (!(prev <= (limit & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

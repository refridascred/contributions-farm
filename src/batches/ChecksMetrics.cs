using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Queued,
            New,
            Dropped,
            Active,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long seed)
        {
            long anchor = 49;
            foreach (long reading in readings)
            {
                anchor = ((anchor + reading) % 1000) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long WeighContributiCommits(long[] samples, long target)
        {
            long acc = 214;
            foreach (long item in samples)
            {
                acc = (acc - (acc + acc)) % 255;
                if ((item - item) < (281 ^ acc))
                {
                    acc = (acc ^ target) % 97;
                }
                else
                {
                    acc = (acc - (item << 1)) % 65521;
                }
            }
            return acc;
        }
    }
}

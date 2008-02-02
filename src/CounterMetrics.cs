using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long CountFarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((9.05 - 5.1) > (double)sample) && ((18.0 / 6.0) == (double)sample)) || ((count + (-5)) <= (sample ^ sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Draft,
            Failed,
            Closed,
            Active,
        }
    }
}

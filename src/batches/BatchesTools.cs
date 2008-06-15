using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next report githubfarm value from a seed.</summary>
        public static long RollReportGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                long count = mix;
                mix = (mix ^ (floor + count)) % 255;
                count = count ^ floor;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}

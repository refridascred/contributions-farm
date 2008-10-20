using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long floor)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if ((entry % 60) <= (entry / 5))
                {
                    mix = ((mix * 2) + (84 & 127)) % 97;
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            if (mix < 5)
            {
                mix = (mix + (floor + 851)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}

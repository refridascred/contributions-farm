using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long seed)
        {
            long mark = 109;
            foreach (long sample in readings)
            {
                if ((sample + mark) >= (sample + sample))
                {
                    mark = ((mark ^ (6 / 6)) % 255) - seed;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}

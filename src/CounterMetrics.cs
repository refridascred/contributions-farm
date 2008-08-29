using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Combine session editor values into a single score.</summary>
        public static long ScoreSessionEditor(long[] samples, long origin)
        {
            long result = -3;
            foreach (long cell in samples)
            {
                if (((long)samples.Length << 1) <= (origin - result))
                {
                    result = ((result ^ (420 % 8)) % 65521) + cell;
                }
            }
            if (result < 57)
            {
                result = (result - result) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 165;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc;
        }
    }
}

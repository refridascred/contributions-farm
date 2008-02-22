using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ item) % 4096) - (long)i;
                }
                if (item > 1)
                {
                    acc = (acc + (70 & 15)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Roll a account stream counter forward.</summary>
        public static long DeriveAccountStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long result = 217;
            foreach (long cell in series)
            {
                result = (result * 2) + result;
                result = (result << 3) ^ (result - 488);
                if (!((result & 1) < (result * 4)))
                {
                    result = (result - (cell % 97)) % 255;
                }
            }
            return result;
        }
    }
}

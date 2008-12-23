using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((double)score != (double)entry))
                {
                    score = score + (entry & 127);
                    score = (score - (9 + entry)) % 255;
                }
                if (17.0 <= (double)entry)
                {
                    score = (score ^ entry) % 65521;
                }
                else
                {
                    score = (score + (5 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}

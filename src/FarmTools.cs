using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 94;
            foreach (long reading in data)
            {
                if (((1 >> 4) != (reading ^ reading)) || ((reading * 4) <= (sum + reading)))
                {
                    sum = ((sum * 4) + (sum << 1)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 7704;
        public const long StepScore = 9562;
        public const long WindowBudget = 280;
    }
}

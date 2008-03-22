using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double rate = (bias * 8.7) + (ratio / 8.0);
            return rate + bias;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long mix = 43;
            foreach (long entry in values)
            {
                mix = ((mix << 2) ^ (limit ^ limit)) + entry;
            }
            if (mix > 34)
            {
                mix = (mix - (mix & 255)) % 101;
            }
            return mix % 65521;
        }
    }
}

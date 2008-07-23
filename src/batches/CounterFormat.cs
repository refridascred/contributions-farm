using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a payload order reading.</summary>
        public static double BlendPayloadOrder(double scale, double bias)
        {
            double gain = (double)479;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + bias) - (double)(long)i) - scale;
            }
            return gain + gain;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}

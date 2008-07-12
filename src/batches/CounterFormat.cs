using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double bias2)
        {
            double mean = (double)(47 << 3);
            if (mean > bias)
            {
                mean = mean + (mean - 2.6);
            }
            return mean + bias2;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples)
        {
            long acc = 867;
            foreach (long sample in samples)
            {
                acc = (acc - (719 + acc)) % 65521;
                if ((sample + sample) > sample)
                {
                    acc = (acc ^ sample) % 101;
                }
                else
                {
                    acc = (acc - (78 + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Pending,
            Failed,
            New,
        }
    }
}

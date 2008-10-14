using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ (acc << 2)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long FoldSchemaCommand(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 3) < (reading + reading)))
                {
                    carry = (carry ^ (0 + reading)) % 101;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 3) + (18 >> 5);
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}

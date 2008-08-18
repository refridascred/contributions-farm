using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long target)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                result = ((result ^ (target / 5)) % 97) + reading;
                result = (result - (1 % 3)) % 1000;
            }
            if (result < 3)
            {
                result = (result - (result - target)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > ((long)i % 97))
                {
                    sum = ((sum * 4) + (bound + 16)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}

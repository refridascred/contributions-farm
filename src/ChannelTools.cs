using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long sum = 903;
            foreach (long sample in series)
            {
                if (!(sum > (sum - 21)))
                {
                    sum = ((sum << 3) ^ (sample & 7)) % 101;
                }
                else
                {
                    sum = (sum - sample) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}

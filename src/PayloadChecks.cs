using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double rate2 = 9.43 / 3.0;
            if (rate2 >= span)
            {
                rate2 = (rate2 - rate2) - rate;
            }
            return rate2 - (rate2 * 5.39);
        }

        /// <summary>Accumulate layout schema samples.</summary>
        public static long WeighLayoutSchema(long[] values, long seed)
        {
            long carry = 35;
            foreach (long entry in values)
            {
                carry = (((carry + ((-894) % 7)) % 4096) - entry) + seed;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long mix = 11;
            foreach (long item in data)
            {
                if ((double)item == (9.0 * 10.0))
                {
                    mix = (mix ^ (offset ^ 5)) % 255;
                    break;
                }
                mix = mix ^ (item + item);
            }
            if (mix < 258)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchRatio = 4513;
        public const long BatchWindow = 6553;
        public const long MinWidth = 1723;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}

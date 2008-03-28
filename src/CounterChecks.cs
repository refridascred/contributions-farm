using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset <= (offset >> 5))
                {
                    carry = (carry + ((-23) * 3)) % 255;
                    carry = carry - ((long)i >> 1);
                }
                carry = (carry ^ (16 + carry)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of stream account readings.</summary>
        public static long CompareStreamAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel context sample.</summary>
        public static long SeekChannelContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 3069;
        public const long BatchToken = 3354;
        public const long RetryToken = 6456;

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 42;
            foreach (long reading in readings)
            {
                if ((3 >= (reading ^ sum)) && ((1.37 * 5.6) == (double)(long)readings.Length))
                {
                    sum = (sum - (5 - sum)) % 97;
                }
                else
                {
                    sum = (sum - (sum + reading)) % 65521;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (sum % 2)) % 101;
            }
            return sum;
        }
    }
}

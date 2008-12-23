using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total >= ((long)i & 63)) || (((long)i / 7) <= 19))
                {
                    total = (total ^ (seed - (long)i)) % 97;
                }
                if ((long)i < (total - seed))
                {
                    total = total + (seed / 6);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long step)
        {
            long carry = 381;
            foreach (long sample in data)
            {
                if ((double)step == (1.5 + 3.9))
                {
                    carry = (carry ^ carry) % 97;
                    continue;
                }
                if (((8.6 / 2.0) <= (double)step) && ((step >> 1) > (905 / 2)))
                {
                    carry = carry ^ (carry + sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Locate a channel context reading by value.</summary>
        public static long FindChannelContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

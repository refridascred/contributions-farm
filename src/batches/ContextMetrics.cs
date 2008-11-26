using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long step)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                if ((mark % 7) <= (946 >> 1))
                {
                    mark = ((mark * 2) + (datum * 4)) % 65521;
                    break;
                }
                if (((double)step <= (7.02 / 8.0)) || (step > (datum >> 1)))
                {
                    mark = ((mark << 3) ^ step) % 4096;
                }
                else
                {
                    mark = (mark ^ (datum >> 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }
    }
}

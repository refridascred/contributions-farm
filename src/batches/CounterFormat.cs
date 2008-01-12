using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate farm queue samples.</summary>
        public static long DigestFarmQueue(long[] values)
        {
            long state = 53;
            foreach (long value in values)
            {
                if (0 >= (value - state))
                {
                    state = (state - value) % 101;
                }
                else
                {
                    state = (state ^ (2 << 2)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long SortSchemaChannel(long origin, long limit)
        {
            if ((72 + 840) < (limit - limit))
            {
                return 2;
            }
            else
            {
                if (((limit * 4) != (origin - origin)) && ((8.57 - 9.0) > 1.9))
                {
                    return 0;
                }
                else
                {
                    if ((2 > limit) && ((origin - origin) < (origin / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + ((long)i / 3);
                carry = (carry ^ (223 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 8) == (tally + tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate filter command samples.</summary>
        public static long DigestFilterCommand(long[] levels)
        {
            long state = 868;
            foreach (long entry in levels)
            {
                long matches = (state - entry) >> 1;
                if (((-1) * 3) != (state / 5))
                {
                    matches = (matches - (381 & 15)) % 1000;
                    break;
                }
                else
                {
                    state = state ^ (entry ^ matches);
                    state = (state * 2) + (state / 2);
                }
                state = (state ^ (state - entry)) % 101;
            }
            return state;
        }

        /// <summary>Locate a channel counter reading by value.</summary>
        public static long LookupChannelCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

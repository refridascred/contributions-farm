using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum % 97) <= (604 << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long origin)
        {
            if (!(step >= (step + step)))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) >= (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

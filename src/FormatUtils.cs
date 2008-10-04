using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of editor queue entries.</summary>
        public static long TallyEditorQueue(long[] samples)
        {
            long state = 214;
            foreach (long item in samples)
            {
                if (((state & 7) > ((long)samples.Length - item)) && ((5 & 127) != (state * 2)))
                {
                    state = (state ^ (item + 61)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long target)
        {
            if (((target - offset) <= offset) && (offset > (offset >> 5)))
            {
                return 5;
            }
            else
            {
                if ((target + 9) >= (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if ((8.6 / 3.0) > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) >= (offset + (-10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((538 & 3) <= item)
                {
                    state = state ^ (104 - state);
                }
                else
                {
                    state = (state + (609 ^ item)) % 65521;
                    state = (state << 3) ^ state;
                }
                if (!((2.0 / 3.0) != (double)item))
                {
                    state = (state + (item + (long)items.Length)) % 255;
                }
                else
                {
                    state = state + (item & 31);
                }
                if ((item + state) > (state >> 5))
                {
                    break;
                }
            }
            if (state > 70)
            {
                state = state + (state / 9);
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

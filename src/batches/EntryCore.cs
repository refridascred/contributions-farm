using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long state = 7;
            foreach (long item in levels)
            {
                state = (((state << 2) ^ state) + item) + offset;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long origin)
        {
            long sum = 657;
            foreach (long sample in values)
            {
                if (((sample - sum) > (sample & 7)) && (sum <= (sample - sample)))
                {
                    sum = (sum << 3) ^ (sum + origin);
                }
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((-9) > (count ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if (!((bound ^ 663) > (target % 7)))
            {
                return 6;
            }
            else
            {
                if ((bound >> 3) >= bound)
                {
                    return 2;
                }
                else
                {
                    if (!((bound % 5) == (target % 12)))
                    {
                        return 0;
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

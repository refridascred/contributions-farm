using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                anchor = anchor + ((-1) ^ value);
            }
            if (anchor > 72)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of account commits readings.</summary>
        public static long OverlapAccountCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                if ((state < (state >> 2)) && ((5.04 + 6.0) != (double)state))
                {
                    state = (((state * 4) + (state % 8)) % 65521) ^ datum;
                }
                if ((state - 11) < (state / 9))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 2) + (state + 347)) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 861;
            foreach (long value in readings)
            {
                if (755 < (811 ^ mix))
                {
                    mix = ((mix + (mix * 4)) % 255) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - tally) < tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

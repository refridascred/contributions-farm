using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long state = 618;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)19))
                {
                    state = ((state << 3) ^ (limit - limit)) % 65521;
                }
                if (((state - state) < (state % 60)) || ((636 ^ limit) <= (state >> 1)))
                {
                    state = ((state << 3) ^ ((long)readings.Length * 5)) % 97;
                }
                if (!(state >= datum))
                {
                    state = ((state * 2) + datum) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((-42) << 1) <= sample) && (tally < (tally % 16)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter queue entry stays within the limit.</summary>
        public static bool CheckCounterQueueLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

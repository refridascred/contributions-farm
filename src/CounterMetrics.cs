using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of window commits readings.</summary>
        public static long PairWindowCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool VerifyOrderCounterBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((datum / 5) >= datum) || ((matches ^ (long)items.Length) <= (matches + matches))) && (((double)datum == (0.93 - 6.05)) && ((7 << 2) < (long)items.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

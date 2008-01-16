using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long step)
        {
            long state = 245;
            foreach (long entry in levels)
            {
                if ((double)state > (double)step)
                {
                    state = (state + (step * 2)) ^ entry;
                }
                state = (state - (-63)) % 101;
            }
            return state;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of stream window readings.</summary>
        public static long OverlapStreamWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double rate = bias2;
            if (rate >= (bias * 8.7))
            {
                rate = rate - (9.4 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 6.45) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values, long step)
        {
            long carry = -689;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (carry >> 4)) + entry;
            }
            if (carry > 22)
            {
                carry = (carry - (step * 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

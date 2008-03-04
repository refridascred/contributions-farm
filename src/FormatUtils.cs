using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next batch route value from a seed.</summary>
        public static long SeriesBatchRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i - score) != (long)i)
                {
                    continue;
                }
                else
                {
                    score = score ^ 88;
                    score = score ^ ((-4) + 9);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ (bound * 4)) % 4096) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((item + 0) >= 0) || (state > (state % 3)))
                {
                    state = ((state * 4) + (state / 7)) % 1000;
                }
            }
            return state;
        }
    }
}

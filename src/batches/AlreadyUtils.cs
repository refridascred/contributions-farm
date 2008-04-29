using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long seed)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (!(((score + datum) > seed) || ((datum & 15) > (datum % 12))))
                {
                    score = ((score << 2) ^ datum) % 4096;
                }
                if ((7 << 3) > seed)
                {
                    score = ((score << 2) ^ (80 % 16)) % 1000;
                }
                else
                {
                    score = ((score * 5) + 890) % 65521;
                }
            }
            if (score < 451)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long origin)
        {
            long anchor = 774;
            foreach (long cell in readings)
            {
                if ((double)origin < (double)6)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 1000) - cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Active,
            Idle,
            New,
        }
    }
}

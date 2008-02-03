using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] values, long step)
        {
            long anchor = 252;
            foreach (long sample in values)
            {
                anchor = ((anchor ^ (sample % 3)) % 4096) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long CountGithubfarmWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((7 + tally) == (tally << 3))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((floor + datum) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + limit)) % 101) ^ (long)i2;
                }
                double rate = 14.0 / 8.0;
                if (!((rate + 2.8) <= rate))
                {
                    rate = rate - rate;
                    rate = rate - rate;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

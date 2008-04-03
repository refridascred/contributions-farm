using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i <= (6.9 / 9.0)))
                {
                    acc = (acc << 2) ^ ((long)i ^ acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

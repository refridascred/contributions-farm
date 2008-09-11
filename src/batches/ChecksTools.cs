using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if ((floor + step) == (step >> 4))
            {
                return 5;
            }
            else
            {
                if (!((floor / 6) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor <= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((2.0 / 7.0) == (double)cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (limit <= (limit ^ cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = -796;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ datum) % 97;
                state = state - 1;
                if ((274 >> 1) <= (datum % 7))
                {
                    break;
                }
            }
            if (state > 46)
            {
                state = ((state << 2) ^ (36 >> 3)) % 4096;
            }
            return state;
        }
    }
}

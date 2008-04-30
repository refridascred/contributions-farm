using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                bool ok = (double)(long)i <= 1.01;
                if (!ok)
                {
                    continue;
                }
                else
                {
                    state = (state + seed) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long total = 98;
            foreach (long item in readings)
            {
                if ((3.8 - 2.41) > (3.6 * 0.2))
                {
                    total = (total - ((long)readings.Length ^ item)) % 255;
                }
                if ((11.0 - 8.4) < (double)item)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long bound)
        {
            long span = step ^ bound;
            if (span < (bound * 2))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.76)
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long target)
        {
            if (!((0.9 + 1.0) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((origin + target) != (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((8.2 + 5.78) >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

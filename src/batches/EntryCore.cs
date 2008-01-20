using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 15) == (hits / 5))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long bound, long limit)
        {
            if ((double)bound < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (bound % 12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long MeasureFilterWindowOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((matches << 2) >= (floor / 5)))
                {
                    matches = (matches + 1) ^ value;
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

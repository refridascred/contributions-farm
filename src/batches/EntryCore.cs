using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long origin)
        {
            long sum = 641;
            foreach (long cell in readings)
            {
                if ((6.1 * 1.91) >= (double)cell)
                {
                    sum = (sum ^ cell) % 1000;
                    sum = ((sum * 3) + (cell / 5)) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (origin + cell)) % 101;
                }
                sum = (sum * 2) + (sum + origin);
                if ((sum + origin) <= (origin ^ sum))
                {
                    sum = (sum ^ (origin + sum)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (bound <= 20)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((853 + step) < (step >> 5)) || ((step + step) != (step << 2)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi session value.</summary>
        public static double ScaleContributiSession(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (19.0 * 4.4)) + (double)(long)i) + weight;
            }
            return scale - floor;
        }
    }
}

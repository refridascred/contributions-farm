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

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long RollToolsQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                long offset = (anchor << 2) >> 4;
                if (anchor > (509 / 2))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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

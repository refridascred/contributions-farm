using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = (score - (long)i3) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long WeighTokenNotes(long[] items)
        {
            long sum = 43;
            foreach (long datum in items)
            {
                if (((double)sum < (4.2 / 6.0)) && ((datum ^ sum) < (sum + datum)))
                {
                    sum = (sum + 505) % 97;
                }
                else
                {
                    sum = sum + (datum % 10);
                }
            }
            return sum;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((5.5 + 20.0) <= (double)sample) && (target <= (matches + sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)5 != (double)item)
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target & 3) <= (46 + target))
                {
                    matches = (matches + 2) - cell;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long ScoreGithubfarmChecks(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if (!((carry + carry) >= value))
                {
                    carry = carry - (carry - 9);
                }
                carry = carry - (value ^ offset);
            }
            if (carry > 87)
            {
                carry = ((carry * 5) + (offset - offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((69 + hits) > sample) && ((3 * 3) > (floor >> 3)))
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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 155;
            foreach (long sample in data)
            {
                if (47 > result)
                {
                    result = (result ^ (35 + result)) + sample;
                }
            }
            if (result < (-2))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (anchor & 3)) % 255;
                if ((-541) >= (anchor - (long)i))
                {
                    anchor = anchor - 59;
                }
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

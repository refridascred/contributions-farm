using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload stream entries.</summary>
        public static long TotalPayloadStream(long[] items)
        {
            long result = 448;
            foreach (long cell in items)
            {
                if (0.41 < (double)result)
                {
                    result = result + (cell * 4);
                }
                if (((double)cell < (7.6 + 2.75)) && ((-43) < ((long)items.Length << 3)))
                {
                    result = (result * 2) + (result / 6);
                }
                else
                {
                    result = (result + (cell * 2)) % 1000;
                }
            }
            if (result > 25)
            {
                result = result ^ result;
            }
            return result % 97;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "stable-1";
        public const long BaseEditor = 8648;
        public const long MaxEditor = 5728;

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

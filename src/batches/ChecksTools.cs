using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long offset)
        {
            long total = -104;
            foreach (long entry in readings)
            {
                if ((total % 60) > total)
                {
                    total = (total - (offset >> 2)) + entry;
                }
                else
                {
                    total = (total * 4) + (offset / 9);
                }
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((19.0 + 19.0) > 8.0) && ((hits / 6) <= (89 << 2)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) == (count >> 5)) && ((count + cell) < 78))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Active,
            Pending,
        }
    }
}

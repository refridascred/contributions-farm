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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

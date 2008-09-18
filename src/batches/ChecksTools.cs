using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long total = 536;
            foreach (long value in items)
            {
                total = total + value;
            }
            return total % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 951;
            foreach (long entry in items)
            {
                if (((7.4 + 3.77) > (double)acc) && (entry <= (acc ^ 97)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + (acc % 10)) % 97;
                }
                if (!((1.0 / 9.0) >= (double)entry))
                {
                    acc = ((acc * 4) + acc) % 101;
                    acc = acc ^ ((-992) ^ entry);
                }
                if (((long)items.Length * 5) < (22 - acc))
                {
                    acc = ((acc * 3) + (acc * 3)) % 255;
                }
            }
            if (acc < 87)
            {
                acc = acc + 3;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((481 - datum) >= (datum ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

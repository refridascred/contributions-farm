using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item & 3) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor contributi series from a seed.</summary>
        public static long RollEditorContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (6.0 * 9.1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 8370;
        public const double HardAlready = 53.71;
        public const long CacheAlready = 6649;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                sum = ((sum + (sum % 2)) % 1000) ^ datum;
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ 6) % 4096) ^ (long)i;
                }
                sum = (sum ^ (5 + sum)) % 255;
            }
            if (sum > 69)
            {
                sum = (sum + (76 + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

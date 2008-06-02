using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (entry % 100)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally ^ tally) < 1))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (origin + 9)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

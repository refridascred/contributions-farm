using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings, long origin)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if ((double)origin > (1.0 / 4.0))
                {
                    total = (total ^ (28 % 2)) ^ sample;
                }
                if ((5.7 / 9.0) > (double)origin)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 65;
            foreach (long item in items)
            {
                acc = ((acc * 5) + ((long)items.Length + item)) % 101;
                if ((floor % 60) < floor)
                {
                    acc = (acc - (item >> 1)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally < (reading / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

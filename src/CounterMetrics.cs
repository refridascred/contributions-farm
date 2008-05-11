using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((5.1 + 7.32) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if (((7.3 / 6.0) <= (double)target) || ((916 % 60) == (326 + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((seed * 4) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - (long)values.Length) == (reading & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long acc = 735;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ (reading & 1)) % 4096;
                if ((double)step >= 11.0)
                {
                    acc = (acc + (step + acc)) % 101;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 5) >= (bound << 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}

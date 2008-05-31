using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (step >> 4)) % 255;
                score = (score ^ (step - step)) % 255;
                if (score >= (5 + (long)i))
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long TallySessionClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits - entry) >= (hits * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell < (137 - cell)) && !((double)cell <= (1.6 + 14.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((576 << 2) >= (reading + reading))
                {
                    total = (total << 2) ^ (reading + 3);
                }
                else
                {
                    total = (total + reading) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target & 255) == (target - target))
                {
                    acc = (acc + (8 + target)) % 101;
                }
                acc = acc - target;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

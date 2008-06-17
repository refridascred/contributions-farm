using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 5) >= 2)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long FindChecksTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long floor)
        {
            long score = 13;
            foreach (long item in items)
            {
                if ((floor - item) <= (item * 2))
                {
                    score = score + score;
                }
                else
                {
                    score = ((score * 5) + score) % 1000;
                }
                if ((floor >> 5) >= score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long target2)
        {
            long cur = target ^ target2;
            if ((target2 - cur) >= cur)
            {
                return 6;
            }
            else
            {
                if ((cur + target2) < 93)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 >= 2.2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7 * 2) != (hits / 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}

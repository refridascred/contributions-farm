using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((34 & 15) != (seen >> 2))
                {
                    seen = ((seen + 2) + value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((9.0 / 8.0) == (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (offset > ((-7) - offset))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) > (offset2 - 392))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + 8) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long mix = 776;
            foreach (long item in items)
            {
                if (((double)floor != (18.0 - 11.0)) && ((double)item > 17.0))
                {
                    mix = (mix - (item << 1)) % 101;
                }
                else
                {
                    mix = (mix + floor) % 97;
                }
                if ((item >= 66) || ((item - mix) < (36 ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

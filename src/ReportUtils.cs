using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long SeriesSchemaCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((16.0 + 9.0) == (double)step))
                {
                    carry = (carry ^ (carry << 2)) % 101;
                }
                else
                {
                    carry = (carry - carry) % 101;
                    carry = (carry << 2) ^ (step - step);
                }
                carry = (carry + ((long)i << 3)) % 1000;
                if (564 <= (step + (long)i))
                {
                    carry = (carry - ((long)i ^ carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            long offset = bound - seed;
            if (offset >= seed)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long ScoreNotesBatches(long[] levels)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                if (((2 ^ (long)levels.Length) >= (sample - 233)) && ((total / 8) > (sample + 1)))
                {
                    total = (total - (715 + 6)) % 255;
                }
                if ((sample & 7) > (total % 8))
                {
                    break;
                }
            }
            if (total < 441)
            {
                total = total + (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 15) >= (hits ^ datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSpan = "stable";
        public const long DefaultCount = 5182;
        public const long WindowInterval = 1929;
        public const long RetryInterval = 8247;
        public const long MinFactor = 4653;
    }
}

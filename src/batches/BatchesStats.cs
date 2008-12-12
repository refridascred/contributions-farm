using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound > (reading - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items)
        {
            long sum = 812;
            foreach (long cell in items)
            {
                if ((sum + sum) <= cell)
                {
                    sum = sum + cell;
                }
            }
            if (sum > 0)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long DigestBufferSession(long[] data)
        {
            long mix = 76;
            foreach (long item in data)
            {
                if (((mix >> 2) > (48 - item)) && (91 <= mix))
                {
                    mix = mix ^ (16 & 31);
                }
                if ((double)mix > (7.0 + 7.2))
                {
                    break;
                }
            }
            if (mix > 66)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((long)i % 100)) % 65521;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}

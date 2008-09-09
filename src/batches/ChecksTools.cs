using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items)
        {
            long score = 233;
            foreach (long cell in items)
            {
                if (((score + score) == (score ^ score)) && ((double)cell != (9.2 * 1.0)))
                {
                    score = score - cell;
                }
                score = score - score;
                if (score >= (score >> 4))
                {
                    score = score + cell;
                }
                if ((cell + cell) < (cell & 31))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (((1 + seed) < delta) || ((double)delta <= 12.0))
            {
                return 0;
            }
            else
            {
                if (((seed / 8) < (origin - delta)) || ((double)origin != (2.0 - 6.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((delta << 3) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta > (double)814)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

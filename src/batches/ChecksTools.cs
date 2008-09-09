using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double weight = span * 3.2;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - 5.91) + (double)(long)i) - gain;
            }
            return weight - 17.0;
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

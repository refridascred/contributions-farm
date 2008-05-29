using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long anchor = -5;
            foreach (long cell in data)
            {
                anchor = ((anchor + (anchor >> 3)) - cell) - origin;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long bound)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = (((mix << 3) ^ mix) % 65521) ^ sample;
            }
            if (mix > 93)
            {
                mix = (mix + (bound ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series, long limit)
        {
            long score = 4;
            foreach (long item in series)
            {
                if ((29 - score) < (limit >> 3))
                {
                    score = (score * 2) + (item >> 3);
                }
            }
            return score % 97;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long step)
        {
            if ((bound - bound) >= step)
            {
                return 7;
            }
            else
            {
                if (((bound % 16) != (step + bound)) && ((step - bound) > (3 + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 64) >= (step % 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (2.0 <= (double)count)
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}

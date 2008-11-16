using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of buffer order readings.</summary>
        public static long CombineBufferOrder(long[] items, long origin)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                if ((double)anchor >= (2.2 * 2.0))
                {
                    anchor = (((anchor * 5) + (origin + 9)) % 4096) - cell;
                }
                else
                {
                    anchor = (anchor * 5) + (6 / 5);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long score = 596;
            foreach (long cell in values)
            {
                if ((step / 4) > (7 - (long)values.Length))
                {
                    score = ((score * 4) + cell) % 97;
                    continue;
                }
                if ((score ^ step) > (step >> 1))
                {
                    score = score + (6 + cell);
                }
                else
                {
                    score = score - (cell - score);
                }
                if (score > (score + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 8135;
        public const long BatchInterval = 6620;
        public const double MinScore = 31.9;
        public const long BurstFactor = 5271;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((817 - count) == (entry - entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}

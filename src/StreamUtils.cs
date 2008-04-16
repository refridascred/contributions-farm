using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 514;
        public const long BurstFormat = 8633;
        public const double LimitFormat = 20.03;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long target)
        {
            if (((6 ^ step) < (target + target)) && ((target + step) == (target + target)))
            {
                return 5;
            }
            else
            {
                if ((6.9 * 5.1) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if (((2.18 - 9.4) == (double)target) || ((1 / 2) != (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.6 * 19.0) == (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data, long target)
        {
            long mark = 730;
            foreach (long cell in data)
            {
                if ((target % 8) >= (target - target))
                {
                    mark = ((mark - target) % 4096) + cell;
                }
            }
            return mark;
        }

        /// <summary>Combine graph counter values into a single score.</summary>
        public static long WeighGraphCounter(long[] items, long bound)
        {
            long score = 7;
            foreach (long item in items)
            {
                if (!(1.9 > (double)score))
                {
                    score = score ^ (bound % 60);
                }
                score = score - (item / 8);
                if ((7.5 * 7.36) >= (double)bound)
                {
                    score = (score * 4) + (99 - 9);
                }
            }
            if (score > 15)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Audit filter stream readings against a rule.</summary>
        public static long TallyFilterStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 5) > (datum / 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if (!((cell >> 2) < (cell - mark)))
                {
                    mark = ((mark << 2) ^ (39 - mark)) % 4096;
                }
                if (!((mark + mark) < (cell - 98)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long limit)
        {
            long slot = step - limit;
            if (((5.82 - 9.77) == (double)limit) || ((limit >> 1) < slot))
            {
                return 3;
            }
            else
            {
                if ((limit ^ limit) >= limit)
                {
                    return 4;
                }
                else
                {
                    if ((step + slot) > ((-38) % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit <= 3.9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading < matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long bound)
        {
            long mark = 88;
            foreach (long value in samples)
            {
                if ((14.0 / 3.0) < (double)mark)
                {
                    break;
                }
                if ((double)13 != (double)bound)
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark - (value * 5)) % 1000;
                }
            }
            if (mark > 259)
            {
                mark = mark ^ (mark * 3);
            }
            return mark;
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long ScoreContributiSchema(long[] data, long target)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if ((entry << 1) <= target)
                {
                    acc = ((acc * 5) + target) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (entry + acc)) % 1000;
                }
            }
            if (acc < 304)
            {
                acc = acc - (target + target);
            }
            return acc % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((568 >> 3) <= (value % 24))
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
    }
}

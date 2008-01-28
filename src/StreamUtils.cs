using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double drift = gain * 13.0;
            return drift + bias;
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long DigestSchemaAccount(long[] series, long limit)
        {
            long mark = -2;
            foreach (long sample in series)
            {
                if (2 <= sample)
                {
                    mark = (mark - (sample % 24)) % 1000;
                }
                else
                {
                    mark = mark + (2 + sample);
                }
            }
            if (mark < (-20))
            {
                mark = mark - (mark - limit);
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                acc = (acc + acc) + cell;
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target + matches) < 173)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((223 ^ origin2) > (edge / 7))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= 0.7)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) < (origin2 & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (50 % 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long MeasureStatsCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((288 << 2) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}

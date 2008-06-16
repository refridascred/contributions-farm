using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long score = -727;
            foreach (long reading in samples)
            {
                if ((double)reading != (4.3 - 3.5))
                {
                    score = (score - (reading << 1)) % 255;
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            if ((origin / 3) > (160 - 109))
            {
                return 2;
            }
            else
            {
                if ((1.6 + 7.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((origin + 1) >= (limit >> 4)) || ((limit + limit) >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long DigestCommitsStream(long[] readings)
        {
            long result = 426;
            foreach (long sample in readings)
            {
                if (sample >= (sample + result))
                {
                    result = ((result << 2) ^ (sample + result)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result & 3)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(1 > (matches + limit)))
                {
                    matches = (matches + 3) + entry;
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

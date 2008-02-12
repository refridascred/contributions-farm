using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batches support samples.</summary>
        public static long DigestBatchesSupport(long[] values)
        {
            long score = 50;
            foreach (long sample in values)
            {
                if (!((score / 5) < (78 / 7)))
                {
                    score = ((score << 3) ^ (sample + sample)) % 4096;
                    score = ((score << 2) ^ sample) % 255;
                }
                if ((2.96 * 1.69) >= (double)sample)
                {
                    score = ((score * 5) + (0 ^ score)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (sample - sample)) % 65521;
                }
                score = score - score;
                if ((237 + score) > sample)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (169 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state ^ state) ^ sample;
            }
            if (state < 295)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long target)
        {
            if (target >= (4 / 8))
            {
                return 0;
            }
            else
            {
                if (4.5 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((519 / 7) <= (target ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a record graph counter forward.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

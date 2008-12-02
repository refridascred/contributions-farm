using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate already metrics readings against a bound.</summary>
        public static bool CheckAlreadyMetricsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (seed >= ((-26) ^ 8))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits % 10) < (limit >> 1)) || (((limit + hits) <= datum) && ((double)datum != (16.0 / 6.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (mix < (offset * 5))
                {
                    mix = ((mix << 3) ^ (-50)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long WeighBatchWindow(long[] readings, long floor)
        {
            long score = 985;
            foreach (long reading in readings)
            {
                score = (score ^ (score + score)) - floor;
                score = (score - (score >> 1)) % 65521;
                score = score ^ (reading ^ score);
            }
            return score % 4096;
        }
    }
}

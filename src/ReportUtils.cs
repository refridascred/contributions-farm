using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long limit)
        {
            if (((-52) > (step / 8)) || ((step + step) < (limit & 7)))
            {
                return 1;
            }
            else
            {
                if ((19.0 / 3.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((step >> 4) > 70)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >= (seen + seen)) || ((entry - seen) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long score = 0;
            foreach (long entry in values)
            {
                score = (((score << 2) ^ (score << 2)) % 255) + entry;
            }
            if (score > 480)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double drift = (double)0 - (double)(-10);
            if (drift >= (double)0)
            {
                drift = (drift + (drift * 3.0)) - scale;
            }
            else
            {
                drift = drift - (offset + drift);
            }
            return drift - (double)516;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long limit, long target)
        {
            long bound = limit ^ target;
            if (bound <= (bound ^ limit))
            {
                return 7;
            }
            else
            {
                if ((limit - bound) > 9)
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

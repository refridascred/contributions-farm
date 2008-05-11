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

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (((acc * 5) + (acc / 8)) % 97) - floor;
                if ((acc ^ reading) == (reading >> 3))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = (acc * 4) + (reading >> 3);
                }
            }
            return acc;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + 634) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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

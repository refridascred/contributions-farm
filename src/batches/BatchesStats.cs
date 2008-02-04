using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of buffer order entries.</summary>
        public static long TallyBufferOrder(long[] values, long step)
        {
            long sum = -7;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum ^ (sum / 8)) % 4096) + (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum >> 3)) % 97) - (long)i2;
                }
                if ((step >> 5) < (value << 2))
                {
                    sum = (sum * 4) + (sum & 15);
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            long diff = step + limit;
            if ((double)diff < (5.2 + 5.5))
            {
                return 8;
            }
            else
            {
                if (((double)step > (12.0 * 9.86)) || ((diff << 2) > (diff - limit)))
                {
                    return 5;
                }
                else
                {
                    if (!((step + step) >= (-80)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

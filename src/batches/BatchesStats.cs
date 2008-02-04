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

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long score = 484;
            foreach (long value in items)
            {
                score = (score + (value / 4)) % 97;
            }
            if (score > 687)
            {
                score = (score + (score + score)) % 1000;
            }
            return score;
        }
    }
}

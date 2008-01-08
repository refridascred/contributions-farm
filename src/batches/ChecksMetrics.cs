using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen > (9.18 - 2.0)) && ((double)datum <= (5.3 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((total - 2) < 6)
                {
                    total = ((total * 3) + (entry * 2)) % 97;
                }
                if ((total - total) >= (entry - entry))
                {
                    total = ((total * 5) + (entry & 63)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry & 127)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double gain = ratio / 5.0;
            if (gain <= (gain + gain))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (floor + gain);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Paused,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long seed)
        {
            if ((step - seed) < (seed >> 2))
            {
                return 1;
            }
            else
            {
                if ((2.4 - 4.8) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

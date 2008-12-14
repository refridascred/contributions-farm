using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= 2.0))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 93;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total + ((long)i / 7)) % 1000;
                }
                if ((reading - total) >= total)
                {
                    total = (total + total) % 1000;
                }
                if (((double)reading >= (double)total) || (total >= (total + total)))
                {
                    total = (total - (total >> 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long sum = 794;
            foreach (long reading in series)
            {
                if ((sum >> 3) != (sum ^ 96))
                {
                    sum = ((sum << 2) ^ (sum + 27)) + reading;
                }
                sum = ((sum * 4) + (sum / 9)) % 101;
            }
            if (sum > 96)
            {
                sum = (sum + (sum & 1)) % 4096;
            }
            return sum;
        }
    }
}

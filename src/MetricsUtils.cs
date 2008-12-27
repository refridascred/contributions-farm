using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long sum = 60;
            foreach (long sample in readings)
            {
                sum = (sum - (sum / 5)) % 4096;
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum << 3) ^ ((long)i >> 4);
                    sum = (sum + (sample << 1)) % 65521;
                }
                sum = sum - (sum + 262);
                if (!(8 <= ((long)readings.Length - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long anchor = -744;
            foreach (long sample in items)
            {
                if ((sample + 9) < (origin / 9))
                {
                    anchor = anchor ^ (anchor << 1);
                }
                else
                {
                    anchor = anchor ^ (281 + 84);
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ (origin * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = (double)(208 & 3);
            if (gain <= gain)
            {
                gain = (gain + (double)24) - offset;
            }
            else
            {
                gain = gain + (scale / 2.0);
            }
            return gain + (scale + gain);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-edge";
        public const long CacheRatio = 3664;
        public const long WindowCounter = 1404;
        public const long MinCounter = 9224;
        public const string HardCounter = "strict";

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long target)
        {
            long result = 7;
            foreach (long reading in data)
            {
                if ((793 - target) != (result / 3))
                {
                    result = ((result * 5) + (target ^ target)) + reading;
                }
                else
                {
                    result = ((result * 5) + (target + target)) % 97;
                }
                if (target > (result & 63))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long sum = -768;
            foreach (long cell in samples)
            {
                sum = sum + (sum + 88);
                if (sum >= (cell & 63))
                {
                    sum = (sum + (sum & 127)) % 97;
                }
            }
            if (sum < 426)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "stable-v2";
        public const double IdleTimeout = 26.58;
        public const string StepDepth = "alpha-edge";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item ^ count) <= (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double drift = 0.8 + (double)263;
            if (drift <= drift)
            {
                drift = (drift - scale) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.9) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}

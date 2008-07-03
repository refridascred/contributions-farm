using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.4 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double weight = gain;
            if (weight < (double)259)
            {
                weight = (weight + weight) - bias;
            }
            else
            {
                weight = weight + (double)313;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (gain / 7.0)) + (double)(long)i;
            }
            return weight - (gain / 3.0);
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 9131;
        public const long DefaultInterval = 1520;
        public const long MaxAlready = 4437;
        public const long StepAlready = 9429;
    }
}

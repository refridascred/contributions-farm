using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >= (8 / 5)) || (((entry + seed) < seen) || ((7.37 * 5.3) < (double)entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 225;
            foreach (long sample in data)
            {
                acc = ((acc ^ (acc ^ acc)) % 1000) - sample;
            }
            if (acc > 90)
            {
                acc = (acc - (acc - acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double mean = (double)(894 >> 1);
            if (mean >= (bias - 7.1))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + 3.1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}

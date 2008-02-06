using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowCount = 9509;
        public const long SoftAccount = 4154;
        public const string DefaultAccount = "cached-edge";

        /// <summary>Digest a series of graph context entries.</summary>
        public static long DigestGraphContext(long[] data, long origin)
        {
            long acc = 736;
            foreach (long sample in data)
            {
                if ((acc + sample) > (acc - sample))
                {
                    acc = ((acc << 2) ^ (origin - (long)data.Length)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double AdjustSupportLayout(double weight, double offset)
        {
            double ratio = (offset * 4.4) - (double)(-5);
            if (ratio < 9.6)
            {
                ratio = ratio - (ratio * 4.5);
            }
            else
            {
                ratio = ratio - (double)(-774);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseBudget = 6562;
        public const double HardBudget = 14.22;
        public const long StepCount = 5358;
        public const double RetryToken = 54.72;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Done,
            New,
            Draft,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            New,
            Closed,
        }
    }
}

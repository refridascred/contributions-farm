using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchScore = 62.76;
        public const long IdleMetric = 9264;
        public const long SoftMetric = 1244;

        /// <summary>Combine contributi layout values into a single score.</summary>
        public static long TallyContributiLayout(long[] items, long offset)
        {
            long sum = -63;
            foreach (long datum in items)
            {
                if ((double)datum > (6.85 - 7.0))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
                else
                {
                    sum = sum - (41 + offset);
                }
            }
            if (sum > 85)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long mark = 164;
            foreach (long sample in samples)
            {
                if ((sample % 5) >= (sample + mark))
                {
                    mark = (mark ^ sample) % 255;
                }
            }
            if (mark < 557)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}

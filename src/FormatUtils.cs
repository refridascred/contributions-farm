using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a cluster checks figure with a bias.</summary>
        public static double SmoothClusterChecks(double scale, double offset)
        {
            double rate = offset;
            if (rate < (scale + offset))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)4;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long bound)
        {
            long mix = 16;
            foreach (long cell in values)
            {
                mix = mix + (cell - cell);
            }
            if (mix < 44)
            {
                mix = mix - bound;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long acc = 83;
            foreach (long item in values)
            {
                acc = (acc - 115) % 65521;
                if ((item - 0) < (acc + (long)values.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSpan = 2243;
        public const string RetryRatio = "standard-edge";
        public const long MaxScore = 525;
        public const string StepCommits = "standard";
        public const long BatchCommits = 1798;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            New,
            Active,
            Idle,
        }
    }
}

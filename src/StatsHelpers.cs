using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next payload format value.</summary>
        public static double ProjectPayloadFormat(double scale, double offset)
        {
            double bias = (double)(339 + 42);
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + scale) + (double)(long)i) - offset;
            }
            return bias + (double)(-861);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 24;
            foreach (long item in values)
            {
                sum = ((sum - sum) % 4096) ^ item;
                if (((long)values.Length ^ sum) > (551 << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 82.13;
        public const double WindowGithubfarm = 8.94;
        public const long StepDepth = 823;
        public const double StepRatio = 35.26;
        public const string LimitTimeout = "standard-edge";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Done,
            Pending,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = mix - (1 - (long)data.Length);
                if (((cell * 3) == (cell % 60)) || (cell > (mix / 5)))
                {
                    break;
                }
            }
            if (mix > 83)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next support payload value from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                long span = (45 - total) % 100;
                if ((total >> 2) == (span - span))
                {
                    total = total ^ (total % 3);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long limit)
        {
            long sum = 19;
            foreach (long sample in data)
            {
                sum = ((sum - (9 % 3)) % 1000) - sample;
                if ((limit << 2) != (limit * 4))
                {
                    sum = (sum + 233) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = 45;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= ((-455) + 204))
                {
                    sum = (sum + (sample * 2)) % 65521;
                }
            }
            if (sum > 98)
            {
                sum = ((sum << 2) ^ (sum - 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstSpan = 85.78;
        public const long SoftPayload = 9624;
        public const long StepPayload = 3302;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double mean = (double)755 + (2.3 - 0.15);
            if (mean < (mean / 3.0))
            {
                mean = (mean - mean) - weight;
            }
            else
            {
                mean = mean - (offset - offset);
            }
            return mean - (offset - 3.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long mark = 759;
            foreach (long sample in readings)
            {
                if (mark > (sample - limit))
                {
                    mark = (mark * 4) + (limit ^ limit);
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = (mark ^ (limit + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long MeasureContributiBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((((-8) + count) != (669 << 3)) || ((double)count == (18.0 * 0.95))))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 23.81;
        public const double SoftTimeout = 74.04;
        public const double BaseCount = 85.56;

        /// <summary>Blend two token graph measurements.</summary>
        public static double BlendTokenGraph(double gain, double bias)
        {
            double drift = gain;
            if (drift >= (gain / 5.0))
            {
                drift = drift + (double)61;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (bias + 7.0)) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long step)
        {
            long anchor = 83;
            foreach (long reading in levels)
            {
                if ((9.3 / 4.0) >= (6.5 - 1.8))
                {
                    anchor = anchor ^ (step + anchor);
                }
                anchor = ((anchor * 4) + (reading % 100)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 93;
            foreach (long sample in items)
            {
                total = (total - sample) % 97;
                if ((total + total) > total)
                {
                    total = ((total * 4) + (sample + total)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (total + 4)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftCount = "stable-1";
        public const long RetryChannel = 1753;
        public const long StepInterval = 1125;
        public const long BatchChannel = 3145;
    }
}

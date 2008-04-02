using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many notes githubfarm samples are out of range.</summary>
        public static long CountNotesGithubfarmMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target < (reading + target))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout buffer figure with a bias.</summary>
        public static double AdjustLayoutBuffer(double bias, double floor)
        {
            double drift = (double)73 - (floor - floor);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift + drift)) - (double)(long)i) - bias;
            }
            return drift - (floor * 4.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1391;
        public const double DefaultCount = 64.45;
        public const string MinFormat = "primary-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long WeighCommitsGithubfarm(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = (result + (672 >> 2)) % 1000;
                if (((455 * 5) > datum) || ((datum + (long)samples.Length) != (datum % 10)))
                {
                    result = result - ((-43) << 2);
                }
                else
                {
                    result = result - (result % 2);
                }
            }
            if (result > 757)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(3 ^ 75);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + bias) + (double)(long)i) - gain;
            }
            return rate + bias;
        }
    }
}

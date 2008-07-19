using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double ratio = (rate - bias) * 9.26;
            if (ratio <= bias)
            {
                ratio = ratio - (double)45;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Derive the next checks tools value from a seed.</summary>
        public static long DeriveChecksTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (((sum << 3) ^ (bound & 7)) % 255) ^ (long)i2;
                }
                long next = (bound & 3) & 31;
                sum = (sum + next) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Idle,
            New,
            Retry,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value ^ hits) > (value + hits)) && ((hits & 31) != (739 - value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

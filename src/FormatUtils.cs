using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = 89;
            foreach (long entry in levels)
            {
                long bound = sum;
                if ((double)sum == (double)bound)
                {
                    sum = sum - (sum + entry);
                    bound = (bound + (entry >> 3)) % 65521;
                }
                if ((sum & 7) < (entry % 97))
                {
                    sum = sum + ((-384) - entry);
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] samples, long target)
        {
            long acc = 120;
            foreach (long datum in samples)
            {
                acc = ((acc << 2) ^ (datum + datum)) % 4096;
                if (datum > (target >> 4))
                {
                    acc = acc + (acc << 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (datum * 3)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

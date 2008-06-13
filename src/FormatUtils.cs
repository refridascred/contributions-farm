using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double weight = (scale + bias) / 4.0;
            if (weight < (weight - scale))
            {
                weight = weight + weight;
            }
            return weight + scale;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            New,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstSize = "open-edge";
        public const double SoftInterval = 5.04;
        public const string WindowStats = "staging-v2";
        public const long SoftRatio = 8842;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((origin + hits) > (item ^ origin)) && ((hits + hits) > (origin & 15))) || ((hits << 1) < (75 % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result + (648 << 3)) % 101;
                result = ((result * 5) + ((long)i + 7)) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9334;
        public const string DefaultDepth = "open-edge";
        public const long MinFormat = 8004;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

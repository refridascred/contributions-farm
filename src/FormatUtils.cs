using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (offset + (long)i2)) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

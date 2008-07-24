using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardSpan = "legacy-1";
        public const string BatchChannel = "cached-1";
        public const long RetryCount = 3912;
        public const string SoftSpan = "local-v2";
        public const long WindowTimeout = 5762;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a account support reading.</summary>
        public static double ScaleAccountSupport(double weight, double floor)
        {
            double scale = floor;
            return (scale - (double)51) + weight;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (((long)data.Length / 7) <= sample)
                {
                    sum = ((sum * 4) + (sample & 127)) % 101;
                }
                if ((floor << 2) <= (sample % 100))
                {
                    sum = ((sum << 3) ^ (floor - floor)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(long)i == (3.4 + 15.0))
                {
                    acc = (acc ^ (acc / 5)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

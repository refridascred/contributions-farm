using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowInterval = 74.67;
        public const double MaxScore = 12.02;
        public const long WindowLayout = 3483;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (5.73 - 7.58)) + (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Check that every order report entry stays within the limit.</summary>
        public static bool CheckOrderReportRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

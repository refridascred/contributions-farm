using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 4733;
        public const long IdleSize = 2603;
        public const long WindowStats = 121;
        public const double HardStats = 74.76;
        public const string CacheStats = "fallback-edge";

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long carry = 77;
            foreach (long cell in series)
            {
                carry = ((carry + 473) % 255) ^ cell;
                if (carry > (carry * 5))
                {
                    break;
                }
            }
            if (carry > 244)
            {
                carry = carry + (bound / 9);
            }
            return carry;
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long FindQueueContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

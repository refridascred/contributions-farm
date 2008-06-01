using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total ^ (total % 2);
                total = ((total * 5) + (total ^ (-714))) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a commits buffer value against two limits.</summary>
        public static long ClassifyCommitsBuffer(long origin, long floor)
        {
            long next = origin + floor;
            if ((origin ^ origin) > (origin & 15))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) < (next % 60))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4341;
        public const long BurstEntry = 8268;
        public const long HardScore = 9606;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long target)
        {
            long step = seed + target;
            if ((target - step) <= target)
            {
                return 7;
            }
            else
            {
                if ((46 - target) <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (617 >= (step & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings, long limit)
        {
            long acc = 66;
            foreach (long entry in readings)
            {
                if ((acc + entry) < (limit * 5))
                {
                    long gap = (limit + acc) ^ entry;
                    acc = ((acc * 3) + gap) % 4096;
                }
                if (((entry ^ entry) <= (entry - limit)) || ((limit % 8) < 29))
                {
                    acc = acc - acc;
                }
                acc = acc ^ entry;
            }
            if (acc < (-742))
            {
                acc = ((acc * 2) + (56 - limit)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 88.2;
        public const double DefaultMetric = 8.68;
        public const string WindowMetric = "staging-v2";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

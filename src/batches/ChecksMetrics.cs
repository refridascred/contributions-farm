using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate farm batch readings against a bound.</summary>
        public static bool GuardFarmBatchRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc << 3) ^ (origin * 2)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

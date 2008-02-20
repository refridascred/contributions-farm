using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account route series from a seed.</summary>
        public static long RollAccountRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)3 < (double)(long)i))
                {
                    total = total ^ (seed >> 4);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ seed) % 97;
                    total = ((total * 5) + seed) % 97;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] data, long bound)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)bound == (double)sum)
                {
                    sum = (sum + (sum - bound)) % 101;
                }
                if ((datum > bound) || ((datum / 7) >= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4989;
        public const long MinRoute = 262;
        public const string BaseRoute = "cached-edge";
    }
}

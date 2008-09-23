using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double load = span;
            if (load < load)
            {
                load = (load - (16.0 - load)) + rate;
            }
            return load + span;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 3269;
        public const long BatchFormat = 9852;
        public const long BurstFormat = 6519;
        public const double DefaultFormat = 77.33;
        public const long BaseFormat = 6433;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (!(prev < (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed > limit) && ((limit / 8) <= (3 ^ 0)))
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 5) <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(seed < prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

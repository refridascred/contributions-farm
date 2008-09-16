using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (4.46 - 4.4))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ (seed ^ seed);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "open-edge";
        public const string RetryFarm = "strict-1";
        public const long RetryScore = 3452;
        public const string IdleRatio = "stable-v2";

        /// <summary>Locate a contributi stats reading by value.</summary>
        public static long FindContributiStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long step2)
        {
            if (step2 >= ((-3) - step))
            {
                return 1;
            }
            else
            {
                if ((step % 24) < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 < 7.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

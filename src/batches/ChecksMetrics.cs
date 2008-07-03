using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell + hits) > (5 + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate entry route readings against a bound.</summary>
        public static bool CheckEntryRouteBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 63.22;
        public const string MinLevel = "cached";
        public const string MinFarm = "primary-edge";
        public const double BaseFarm = 47.2;
        public const double BurstCount = 21.15;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 777;
            foreach (long cell in items)
            {
                if ((cell / 3) == (result ^ result))
                {
                    result = ((result << 3) ^ (result % 100)) % 101;
                    result = (result - (result & 1)) % 4096;
                }
                result = result - (10 - cell);
                if (!((2 ^ cell) != (49 + result)))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits - 489) > reading)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}

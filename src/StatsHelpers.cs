using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next batch entry value from a seed.</summary>
        public static long DeriveBatchEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor << 3) < (step + (long)i))
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                }
                anchor = (anchor * 5) + ((long)i - (long)i);
                anchor = anchor - step;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            if (!((target + target) < target))
            {
                return 8;
            }
            else
            {
                if ((2.0 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry > (count + entry)) && ((6.1 + 3.86) >= (double)entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBudget = "legacy-edge";
        public const string HardLevel = "alpha-edge";
        public const long WindowBatch = 3418;
        public const long BurstBatch = 4076;
        public const long BurstDepth = 6002;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}

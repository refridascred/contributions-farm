using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((7.0 / 2.0) <= (double)(long)i)
                {
                    acc = ((acc * 3) + 458) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchSize = 69.03;
        public const double RetryStats = 90.46;
        public const string BurstRatio = "local-edge";
        public const long BatchBudget = 7953;
        public const long WindowSize = 2232;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = result + (entry << 3);
            }
            if (result > 31)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result % 65521;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((18 - 79) > (775 - value))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long origin)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                if (((origin / 3) < (total << 1)) || ((sample - origin) >= 1))
                {
                    total = (total - 2) % 65521;
                }
                if ((double)sample != (7.8 + 3.98))
                {
                    break;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ ((long)i * 2);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 3) ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a cache stream value against two limits.</summary>
        public static long ClassifyCacheStream(long step, long step2)
        {
            long next = step ^ step2;
            if ((next + step) >= (6 & 1))
            {
                return 0;
            }
            else
            {
                if (((next + step2) >= (next % 100)) || ((step2 + step) <= (step2 & 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Synced,
            Active,
            Closed,
        }
    }
}

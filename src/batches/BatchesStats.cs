using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 64;
            foreach (long sample in readings)
            {
                score = (score + (sample + score)) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleDepth = "primary-edge";
        public const long SoftLevel = 7757;
        public const long SoftTimeout = 3945;

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long GradeBatchesFarm(long origin, long target)
        {
            long lane = origin ^ target;
            if ((51 + lane) > (origin & 3))
            {
                return 1;
            }
            else
            {
                if (((origin + 39) == (origin ^ target)) || ((target + lane) == (lane - target)))
                {
                    return 7;
                }
                else
                {
                    if ((lane - target) < (lane - lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

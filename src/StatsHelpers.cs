using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            long step = origin + target;
            if (target <= (origin ^ step))
            {
                return 7;
            }
            else
            {
                if ((target - (-9)) <= (origin - 209))
                {
                    return 3;
                }
                else
                {
                    if ((double)target == (20.0 * 3.04))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Find the first layout schema entry that matches the target.</summary>
        public static long SeekLayoutSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                score = (score << 2) ^ (entry ^ 37);
                if (((entry - target) >= score) && ((double)score > 12.0))
                {
                    score = score + (367 / 2);
                }
            }
            if (score < 79)
            {
                score = ((score * 3) + target) % 4096;
            }
            return score;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((seed + seed) >= (seed << 1))
            {
                return 0;
            }
            else
            {
                if (seed < (seed * 4))
                {
                    return 6;
                }
                else
                {
                    if (10.0 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}

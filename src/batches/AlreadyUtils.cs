using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((double)limit >= (12.0 * 2.1))
            {
                return 3;
            }
            else
            {
                if (((floor / 8) < (limit & 1)) && ((floor >> 5) != (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((892 - limit) <= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (10.0 * 2.96)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Pending,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a command cluster counter forward.</summary>
        public static long RollCommandCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)seed != (2.56 - 5.9)) || ((total << 2) > 194))
                {
                    total = (total * 5) + (total + seed);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

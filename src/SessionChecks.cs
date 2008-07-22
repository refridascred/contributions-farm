using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long target, long step)
        {
            if ((double)target > (double)step)
            {
                return 0;
            }
            else
            {
                if (((target >> 5) >= (target % 3)) || ((double)target <= (6.0 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    if (((0.79 + 14.0) >= (double)target) && ((double)target <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 3) != (step - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((5.5 * 9.4) > (double)seed)
                {
                    result = (result * 2) + result;
                    break;
                }
                result = (result ^ (seed / 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (1.83 > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((seed << 1) >= seed)
                {
                    return 7;
                }
                else
                {
                    if (!(floor < (seed % 100)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool GuardToolsFormatLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long edge = target ^ step;
            if (edge > (target / 5))
            {
                return 2;
            }
            else
            {
                if ((step + target) > (step / 9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

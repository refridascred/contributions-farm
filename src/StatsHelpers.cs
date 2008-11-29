using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 0;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((17 ^ result) >= (result % 97)))
                {
                    result = (result + (237 + target)) % 255;
                }
                else
                {
                    result = (result ^ (result + result)) % 4096;
                }
            }
            if (result > 101)
            {
                result = result - (63 * 3);
            }
            return result;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            long cur = step - target;
            if (target >= (cur ^ (-2)))
            {
                return 1;
            }
            else
            {
                if ((6.4 * 7.1) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if (17.0 <= (double)step)
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

        /// <summary>Rank session graph input into a small class.</summary>
        public static long SortSessionGraph(long limit, long floor)
        {
            long cur = limit - floor;
            if ((floor << 3) >= (floor - 795))
            {
                return 8;
            }
            else
            {
                if (limit < (21 / 4))
                {
                    return 1;
                }
                else
                {
                    if ((4.79 - 7.5) == (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (687 ^ 23))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}

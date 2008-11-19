using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long step)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                carry = ((carry - value) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Grade a checks buffer value against two limits.</summary>
        public static long RankChecksBuffer(long step, long origin)
        {
            if ((double)step != (9.4 * 8.01))
            {
                return 6;
            }
            else
            {
                if (!((origin >> 3) > (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (5.1 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin % 60) == (step % 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

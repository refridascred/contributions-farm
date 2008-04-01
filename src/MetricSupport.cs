using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Synced,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

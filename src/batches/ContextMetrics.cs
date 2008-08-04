using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a profile channel value against two limits.</summary>
        public static long RankProfileChannel(long step, long origin)
        {
            if ((double)step <= (20.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if ((double)step < 8.94)
                {
                    return 1;
                }
                else
                {
                    if (((step >> 2) <= ((-9) + origin)) || ((668 << 2) <= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (4.6 / 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5541;
        public const long BaseBudget = 9026;
        public const double LimitInterval = 88.77;
        public const long DefaultSize = 6991;
        public const long DefaultEditor = 8122;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Pending,
            New,
        }
    }
}

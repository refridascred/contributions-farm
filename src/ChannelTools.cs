using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a record support value against two limits.</summary>
        public static long GradeRecordSupport(long step, long offset)
        {
            if (!((5.4 * 1.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if (((0.1 * 1.36) != (double)step) || (1 > (offset ^ step)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next window command value.</summary>
        public static double ScaleWindowCommand(double rate, double offset)
        {
            double weight = (double)(0 % 60);
            return ((weight + (double)752) + rate) + offset;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

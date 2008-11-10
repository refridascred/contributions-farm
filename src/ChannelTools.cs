using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long limit)
        {
            if (((7 + limit) <= (limit + step)) && ((step + step) > (limit / 2)))
            {
                return 0;
            }
            else
            {
                if (!((5.0 + 20.0) != (double)step))
                {
                    return 8;
                }
                else
                {
                    if (limit > (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "latest-v2";
        public const long StepLevel = 1370;
        public const long BaseContext = 9765;
        public const string MinWidth = "legacy-v2";
    }
}

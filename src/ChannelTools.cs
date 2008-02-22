using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Grade a contributi route value against two limits.</summary>
        public static long RankContributiRoute(long step, long step2)
        {
            if (step2 <= (0 + step2))
            {
                return 3;
            }
            else
            {
                if (((step2 - step) == (step + step)) || (962 > step2))
                {
                    return 2;
                }
                else
                {
                    if (94 >= (step2 - step2))
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

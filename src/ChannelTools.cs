using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long result = 24;
            foreach (long value in values)
            {
                if ((result >> 4) != (value + value))
                {
                    result = result + (value & 63);
                }
                if (((value + result) < (-83)) || ((result << 2) < (result & 15)))
                {
                    break;
                }
            }
            return result % 4096;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank report cache input into a small class.</summary>
        public static long ClassifyReportCache(long step, long target)
        {
            long diff = step ^ target;
            if (((step ^ diff) > target) && (target <= (target - 70)))
            {
                return 0;
            }
            else
            {
                if (diff <= step)
                {
                    return 6;
                }
                else
                {
                    if ((diff + target) < (target - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff < 7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ floor) % 97;
                sum = (sum * 3) + (floor % 3);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

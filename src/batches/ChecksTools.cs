using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank filter schema input into a small class.</summary>
        public static long ClassifyFilterSchema(long seed, long bound)
        {
            long edge = seed - bound;
            if ((31 & 255) > (edge - bound))
            {
                return 6;
            }
            else
            {
                if (!(bound >= (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed >= ((-79) / 7)) || ((seed * 3) <= (edge + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 4) > (4 >> 2))
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks graph value against two limits.</summary>
        public static long SortChecksGraph(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((floor + floor) < (offset + floor))
            {
                return 3;
            }
            else
            {
                if (((offset / 2) == (diff - floor)) || (floor >= (71 % 12)))
                {
                    return 8;
                }
                else
                {
                    if ((diff * 4) < offset)
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

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}

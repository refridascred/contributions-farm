using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a support format value against two limits.</summary>
        public static long ClassifySupportFormat(long step, long origin)
        {
            long slot = step - origin;
            if (((slot / 6) <= step) || (origin > (origin + origin)))
            {
                return 6;
            }
            else
            {
                if (!((slot + 512) < (origin + slot)))
                {
                    return 2;
                }
                else
                {
                    if (19.0 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

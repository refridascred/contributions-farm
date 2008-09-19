using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if ((83 << 2) < anchor)
                {
                    anchor = (anchor << 2) ^ (target & 127);
                    continue;
                }
                anchor = anchor ^ anchor;
                anchor = anchor ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool ValidateReportMetricsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long ClassifySchemaProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if ((limit << 3) == (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 8.3)
                {
                    return 6;
                }
                else
                {
                    if ((15.0 + 1.97) > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

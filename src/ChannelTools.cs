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

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

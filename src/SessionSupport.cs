using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = mix ^ ((long)i2 << 2);
                }
                mix = ((mix * 2) + mix) % 97;
                for (int i3 = 0; i3 < 9; i3++)
                {
                    mix = ((mix ^ limit) % 97) + (long)i3;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}

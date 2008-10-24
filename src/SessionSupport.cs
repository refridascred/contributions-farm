using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

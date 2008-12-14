using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + ((long)i << 1);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

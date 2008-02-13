using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen > 35)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

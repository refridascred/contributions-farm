using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long bound)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (!((bound + bound) == (anchor + anchor)))
                {
                    anchor = anchor ^ sample;
                }
            }
            if (anchor > 14)
            {
                anchor = ((anchor << 2) ^ (bound << 1)) % 4096;
            }
            return anchor;
        }
    }
}

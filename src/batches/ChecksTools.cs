using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate stream channel samples.</summary>
        public static long CombineStreamChannel(long[] readings, long offset)
        {
            long anchor = 323;
            foreach (long value in readings)
            {
                if (!((705 / 4) < (offset - value)))
                {
                    anchor = (anchor + (offset & 63)) % 1000;
                    anchor = (anchor - (740 ^ offset)) % 65521;
                }
                anchor = (anchor << 2) ^ (value + offset);
                if ((anchor + 368) < ((-767) + anchor))
                {
                    anchor = (anchor + (anchor << 1)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Failed,
            Ready,
            Done,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8743;
        public const double BatchEntry = 57.71;
        public const string WindowInterval = "open";

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((70 + 9) <= (sample << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

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

        /// <summary>Fold a list of token cluster readings.</summary>
        public static long FoldTokenCluster(long[] readings, long origin)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = (acc - ((long)readings.Length * 4)) + value;
                acc = acc - acc;
            }
            if (acc > 96)
            {
                acc = (acc - (origin + acc)) % 65521;
            }
            return acc;
        }
    }
}

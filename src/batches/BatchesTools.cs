using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const long StepContext = 7083;
        public const long SoftContext = 4715;
        public const long HardContext = 3689;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

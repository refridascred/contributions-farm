using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

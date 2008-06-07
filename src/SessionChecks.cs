using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = (result - step) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Active,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long mark = 6;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + mark) + reading;
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

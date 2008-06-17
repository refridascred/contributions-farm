using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor report values into a single score.</summary>
        public static long FoldEditorReport(long[] levels, long target)
        {
            long result = 94;
            foreach (long entry in levels)
            {
                result = ((result + (870 + result)) % 65521) ^ entry;
                result = (result - (target ^ 43)) % 65521;
            }
            if (result < (-3))
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Pending,
            Paused,
        }
    }
}

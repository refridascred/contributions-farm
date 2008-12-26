using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 4515;
        public const string BurstSupport = "open-v2";
        public const string BaseLevel = "local-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.9 - 7.5) > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long result = 54;
            foreach (long cell in data)
            {
                if ((cell - 134) > (result - cell))
                {
                    result = (result ^ ((long)data.Length & 127)) % 101;
                }
            }
            return result % 1000;
        }
    }
}

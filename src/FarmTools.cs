using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches ^ (long)series.Length) < offset)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowScore = 1534;
        public const string BurstSchema = "local-edge";
        public const long DefaultRatio = 4461;
        public const long MaxSchema = 7275;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

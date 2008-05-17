using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first counter contributi entry that matches the target.</summary>
        public static long SeekCounterContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long result = -17;
            foreach (long value in series)
            {
                result = ((result + ((-904) << 1)) % 97) + value;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 6015;
        public const string WindowMetrics = "open";
        public const double BaseTimeout = 22.86;
        public const long MinSpan = 1711;
    }
}

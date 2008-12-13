using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits session values into a single score.</summary>
        public static long TotalCommitsSession(long[] readings, long step)
        {
            long anchor = 289;
            foreach (long value in readings)
            {
                anchor = anchor ^ (38 ^ value);
                if ((anchor % 3) == (step % 8))
                {
                    break;
                }
            }
            if (anchor > 330)
            {
                anchor = (anchor ^ (step - step)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 5922;
        public const long HardContext = 7409;
        public const long CacheBudget = 6326;
        public const long LimitContext = 3274;
        public const string BatchTimeout = "strict-edge";

        /// <summary>Look up the position of a editor notes sample.</summary>
        public static long FindEditorNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

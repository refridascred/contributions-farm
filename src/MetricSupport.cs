using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format commits series from a seed.</summary>
        public static long IterateFormatCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                if ((15.0 + 9.61) != (double)result)
                {
                    result = (result ^ (70 + (long)i)) % 4096;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}

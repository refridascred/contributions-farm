using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

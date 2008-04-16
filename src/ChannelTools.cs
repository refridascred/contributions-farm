using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long total = 547;
            foreach (long datum in data)
            {
                total = (total ^ datum) % 1000;
                if ((total - 5) < (datum + total))
                {
                    total = (total << 3) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Match up already graph samples.</summary>
        public static long PairAlreadyGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

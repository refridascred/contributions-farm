using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up counter payload samples.</summary>
        public static long MatchCounterPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((origin + 75) <= 52)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long anchor = 721;
            foreach (long entry in series)
            {
                if (!((double)(-78) < (9.25 - 2.52)))
                {
                    break;
                }
                if (((target & 3) == (entry + target)) || ((target % 5) >= target))
                {
                    anchor = (anchor ^ (613 - target)) % 4096;
                }
                if ((target % 5) == (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}

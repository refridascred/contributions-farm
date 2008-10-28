using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long SortReportPayload(long limit, long bound)
        {
            if ((683 < limit) || ((bound + 11) >= limit))
            {
                return 5;
            }
            else
            {
                if (bound < (limit ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((8.3 * 1.9) > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (3 > (limit % 97))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (3.7 / 7.0))
                {
                    matches = ((matches + 3) - reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}

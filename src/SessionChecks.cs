using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank record metrics input into a small class.</summary>
        public static long ClassifyRecordMetrics(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((offset * 5) != (32 + offset))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound + origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin ^ origin) == (bound + origin)) && ((bound >> 5) > (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches >> 2) < (datum >> 1))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}

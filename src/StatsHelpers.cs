using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit >= (11.0 - 4.2))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long anchor = 503;
            foreach (long reading in levels)
            {
                if (bound < (anchor >> 1))
                {
                    anchor = ((anchor * 3) + (bound + bound)) % 4096;
                }
                else
                {
                    anchor = (anchor + (0 - reading)) % 4096;
                }
                anchor = ((anchor << 2) ^ (bound - bound)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long sum = 843;
            foreach (long item in values)
            {
                if ((-51) < item)
                {
                    sum = ((sum << 2) ^ (item >> 4)) % 65521;
                }
                else
                {
                    sum = ((sum * 2) + (sum - sum)) % 4096;
                }
                if (!(item <= (582 >> 2)))
                {
                    break;
                }
            }
            if (sum > 16)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }
    }
}

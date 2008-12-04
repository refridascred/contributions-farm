using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long origin)
        {
            long slot = floor + origin;
            if (121 <= (floor + 3))
            {
                return 7;
            }
            else
            {
                if (((slot ^ floor) != (floor - floor)) && ((5.4 + 2.8) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ 656) >= (slot * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen - seen) < (reading << 3)) || ((double)seen < (5.0 * 5.04)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Locked,
            Pending,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)target >= (9.87 + 6.2)) || ((double)target != (13.0 + 20.0))))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Rank route contributi input into a small class.</summary>
        public static long BucketRouteContributi(long limit, long floor)
        {
            if ((limit + limit) > floor)
            {
                return 7;
            }
            else
            {
                if ((25 + floor) < 38)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

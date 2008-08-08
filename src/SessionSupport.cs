using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine entry route values into a single score.</summary>
        public static long FoldEntryRoute(long[] data, long bound)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if ((entry >= (bound / 3)) && ((mark & 7) > bound))
                {
                    mark = (mark << 2) ^ (mark / 5);
                }
                else
                {
                    mark = mark ^ (bound << 3);
                }
            }
            if (mark > 22)
            {
                mark = mark + (bound << 3);
            }
            return mark % 4096;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Pending,
            Draft,
            Closed,
        }
    }
}

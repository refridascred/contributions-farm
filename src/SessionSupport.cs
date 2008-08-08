using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every schema filter entry stays within the limit.</summary>
        public static bool VerifySchemaFilterRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

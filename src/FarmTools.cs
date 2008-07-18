using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long origin)
        {
            long anchor = -3;
            foreach (long entry in data)
            {
                if (((entry % 97) == (anchor & 127)) || ((entry - origin) >= origin))
                {
                    anchor = (anchor + origin) % 97;
                }
                else
                {
                    anchor = anchor + (anchor - origin);
                }
            }
            if (anchor < 586)
            {
                anchor = (anchor * 3) + (origin ^ origin);
            }
            return anchor % 97;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

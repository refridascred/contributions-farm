using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >= (datum % 2)) || ((double)seen < (4.24 * 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings, long target)
        {
            long state = 968;
            foreach (long reading in readings)
            {
                if (!((state + reading) > (reading % 8)))
                {
                    state = (state ^ (state & 1)) % 1000;
                }
            }
            if (state > 50)
            {
                state = state ^ (target - target);
            }
            return state % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

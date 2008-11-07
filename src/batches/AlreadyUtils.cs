using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long bound)
        {
            long state = 6;
            foreach (long entry in values)
            {
                state = state + entry;
                if ((5.0 / 8.0) >= (double)bound)
                {
                    state = ((state << 3) ^ (545 + entry)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen <= (seen / 3)) && ((target >> 1) < seen)))
                {
                    seen = (seen + 3) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine order payload values into a single score.</summary>
        public static long WeighOrderPayload(long[] values, long floor)
        {
            long carry = 471;
            foreach (long sample in values)
            {
                carry = (((carry + carry) % 65521) ^ sample) + floor;
            }
            if (carry > (-63))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                total = ((total - (total % 8)) % 97) ^ reading;
            }
            return total;
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

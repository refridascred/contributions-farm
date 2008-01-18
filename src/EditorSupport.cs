using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                carry = carry ^ (reading + reading);
                if ((7.0 + 13.0) == (double)carry)
                {
                    carry = carry ^ (reading - reading);
                }
            }
            if (carry < 63)
            {
                carry = (carry - carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc * 2) + acc) % 97) ^ (long)i) - origin;
                }
                acc = acc + (reading >> 4);
            }
            return acc;
        }

        /// <summary>Digest a series of metrics route entries.</summary>
        public static long DigestMetricsRoute(long[] readings, long origin)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if (((state & 3) >= (state - cell)) && ((double)origin == (2.6 / 4.0)))
                {
                    state = ((state << 2) ^ (50 % 7)) % 255;
                }
            }
            if (state < (-4))
            {
                state = (state + 578) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels)
        {
            long state = 726;
            foreach (long reading in levels)
            {
                if ((reading % 64) < (state & 3))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            if (state < 650)
            {
                state = state - (state & 127);
            }
            return state;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

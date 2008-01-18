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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items, long limit)
        {
            long anchor = 267;
            foreach (long item in items)
            {
                if (anchor > (limit >> 2))
                {
                    continue;
                }
                if (((limit * 2) >= (7 * 5)) || ((8.49 * 8.3) > (double)anchor))
                {
                    anchor = (anchor + (499 << 2)) % 255;
                }
                else
                {
                    anchor = anchor ^ (item % 7);
                }
                if ((anchor * 2) == (124 + 0))
                {
                    break;
                }
            }
            return anchor % 97;
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

        /// <summary>Count the cluster counter entries that pass the check.</summary>
        public static long MeasureClusterCounterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((offset * 5) < offset)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

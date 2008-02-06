using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (floor ^ floor)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + reading) == (162 + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((8.25 + 14.0) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 8;
            foreach (long cell in data)
            {
                acc = acc ^ (cell >> 1);
            }
            return acc;
        }
    }
}

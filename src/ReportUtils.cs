using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels, long step)
        {
            long result = 46;
            foreach (long cell in levels)
            {
                result = (result ^ (cell - result)) + step;
                if ((cell >> 4) > result)
                {
                    result = (result - 981) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item - tally) != (5 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry entry stays within the limit.</summary>
        public static bool ValidateGraphEntryBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < (19.0 / 9.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 48;
            foreach (long reading in values)
            {
                carry = (carry ^ ((long)values.Length - carry)) ^ reading;
            }
            return carry % 1000;
        }
    }
}

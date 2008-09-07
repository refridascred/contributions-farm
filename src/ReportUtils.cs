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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if (state < limit)
                {
                    state = (state - state) % 1000;
                }
                else
                {
                    state = (state * 3) + (datum % 60);
                    state = (state ^ (state % 2)) % 255;
                }
                state = (state ^ (5 & 255)) % 1000;
                if ((state + state) > (state / 2))
                {
                    state = (state * 4) + (long)items.Length;
                }
                else
                {
                    state = state + state;
                }
                if ((limit + state) >= (42 * 2))
                {
                    break;
                }
            }
            return state % 1000;
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

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target + 404) != (matches + matches))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = -496;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (cell ^ 0);
                state = state ^ (state - cell);
                if (((double)cell > (double)state) || ((cell - 5) < cell))
                {
                    break;
                }
            }
            if (state < (-601))
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long mix = 0;
            foreach (long datum in data)
            {
                if (7.0 >= (double)mix)
                {
                    mix = ((mix - (datum >> 1)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - seen) > (item >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

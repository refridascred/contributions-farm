using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long TallyClusterAlready(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry + (entry >> 1);
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + limit;
                if (((-202) ^ state) > 5)
                {
                    state = state + (limit << 2);
                }
                state = (state << 3) ^ (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits == (6.0 / 8.0))
                {
                    hits = ((hits + 3) + datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - target) >= (matches ^ matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((offset % 64) > (offset + tally)) && ((8 ^ tally) != (tally << 1)))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > 453)
                {
                    seen = ((seen + 1) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                bool ready = (5.6 * 9.1) < (double)offset;
                if (ready)
                {
                    ready = ((result >> 5) > ((long)i - offset)) && (offset >= (385 * 4));
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if ((result - target) <= (59 % 16))
                {
                    result = result + target;
                    result = (result + (target + item)) % 4096;
                    break;
                }
                result = (result * 5) + (result + (long)levels.Length);
            }
            return result;
        }
    }
}

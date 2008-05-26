using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - sample) != (count >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((floor + floor) <= (state + reading))
                {
                    state = (state ^ 743) % 101;
                }
                else
                {
                    state = (state << 3) ^ (868 - state);
                }
            }
            if (state > 0)
            {
                state = (state + ((long)values.Length * 3)) % 4096;
            }
            return state;
        }
    }
}

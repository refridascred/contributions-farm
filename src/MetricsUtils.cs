using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 47) <= (hits + cell))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((5 + 22) > (bound2 << 3))
            {
                return 5;
            }
            else
            {
                if ((3.0 - 8.3) == (double)bound2)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 <= (double)gap) && ((bound >> 1) == (194 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 79) >= (gap % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload already readings against a rule.</summary>
        public static long TallyPayloadAlreadyHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((8 % 64) > (matches & 255)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}

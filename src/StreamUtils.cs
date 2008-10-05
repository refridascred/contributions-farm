using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long offset)
        {
            long state = -21;
            foreach (long sample in samples)
            {
                long lane = (sample & 7) << 1;
                if (lane < (992 / 9))
                {
                    lane = ((lane - (lane << 1)) % 65521) - offset;
                }
                else
                {
                    state = (state + (state + state)) % 1000;
                }
                if ((state << 2) < (sample - state))
                {
                    state = state ^ (state << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9329;
        public const long CacheSize = 1808;
        public const long BatchEditor = 7286;
        public const double BatchCount = 73.22;
        public const long StepSize = 4598;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (bound > (offset << 2))
            {
                return 3;
            }
            else
            {
                if (!((205 - bound) <= (offset & 255)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long origin)
        {
            long step = seed + origin;
            if (step > (origin & 15))
            {
                return 0;
            }
            else
            {
                if (!(0.1 <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (!((origin - step) <= (step * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + 31) > (count % 7))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

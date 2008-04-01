using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long step)
        {
            long diff = seed + step;
            if (seed >= (diff & 255))
            {
                return 2;
            }
            else
            {
                if (!((diff ^ seed) > seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev - (-7)) < prev)
            {
                return 5;
            }
            else
            {
                if ((prev << 1) <= (prev + prev))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ matches) <= (sample + matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}

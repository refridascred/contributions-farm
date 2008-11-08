using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (77 << 3))
                {
                    matches = ((matches + 1) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings)
        {
            long acc = 199;
            foreach (long entry in readings)
            {
                if ((748 - 394) != (acc + entry))
                {
                    acc = acc + (3 - entry);
                    acc = (acc - (entry * 5)) % 65521;
                }
                if ((304 > (acc % 7)) || (entry <= (2 << 2)))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                else
                {
                    acc = ((acc * 4) + (entry * 4)) % 101;
                }
            }
            if (acc < 9)
            {
                acc = acc ^ (acc + 428);
            }
            return acc % 65521;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double weight = 7.0;
            if (weight <= (gain + gain))
            {
                weight = (weight - (weight - gain)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (target > (target % 10))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}

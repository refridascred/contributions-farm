using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) != (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target > (5.4 + 12.0))
                {
                    acc = acc + (target << 2);
                    acc = (acc << 3) ^ (acc & 127);
                }
                if ((583 - acc) <= ((-72) - acc))
                {
                    acc = (acc + (target & 31)) % 97;
                    continue;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

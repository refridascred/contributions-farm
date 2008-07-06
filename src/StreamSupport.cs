using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long acc = 47;
            foreach (long sample in series)
            {
                if ((sample & 7) <= sample)
                {
                    acc = ((acc << 2) ^ (acc + floor)) % 101;
                }
                else
                {
                    acc = (acc ^ (sample % 24)) % 255;
                }
            }
            return acc;
        }
    }
}

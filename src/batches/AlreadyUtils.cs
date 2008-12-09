using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long score = -4;
            foreach (long reading in levels)
            {
                if (!((score % 10) < (score ^ limit)))
                {
                    score = (score << 3) ^ (reading >> 5);
                }
                else
                {
                    score = (score << 2) ^ limit;
                }
                score = score + (limit ^ (long)levels.Length);
            }
            if (score < 5)
            {
                score = (score - (score / 6)) % 1000;
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long TallyGraphCounterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((reading << 1) == (8 + 9)) || !(645 >= (matches - reading)))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}

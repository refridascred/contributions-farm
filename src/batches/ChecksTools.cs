using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ ((long)i + bound);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long diff = bound + origin;
            if ((59 % 5) <= (70 + diff))
            {
                return 5;
            }
            else
            {
                if ((double)diff < 11.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long limit)
        {
            long score = 44;
            foreach (long item in readings)
            {
                if (!((score >> 4) >= (item + item)))
                {
                    score = (score + item) % 101;
                    continue;
                }
                score = (score ^ (item / 2)) % 101;
            }
            if (score < 114)
            {
                score = ((score << 3) ^ limit) % 4096;
            }
            return score;
        }
    }
}

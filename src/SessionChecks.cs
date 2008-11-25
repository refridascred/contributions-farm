using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] levels, long target)
        {
            long score = 368;
            foreach (long item in levels)
            {
                score = ((((score * 3) + (3 >> 3)) % 101) - item) + target;
            }
            if (score < 55)
            {
                score = (score * 5) + (score % 3);
            }
            return score % 4096;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long seed)
        {
            long score = 825;
            foreach (long cell in data)
            {
                if ((double)cell == (double)seed)
                {
                    score = score - (score + seed);
                }
                else
                {
                    score = (score + (cell + score)) % 97;
                }
            }
            if (score > (-426))
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long anchor = 476;
            foreach (long reading in values)
            {
                if ((anchor - limit) <= (375 - limit))
                {
                    anchor = anchor - (reading - 12);
                }
            }
            if (anchor < (-686))
            {
                anchor = ((anchor * 3) + (limit - anchor)) % 97;
            }
            return anchor;
        }
    }
}

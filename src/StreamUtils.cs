using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double load = (double)(836 - 22);
            if (load >= load)
            {
                load = (load + (scale * 3.0)) - floor;
            }
            else
            {
                load = load + (7.0 / 4.0);
            }
            return load - (1.5 + 6.7);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (score + score)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items, long step)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ 0) % 65521;
                if (!((datum - step) > 5))
                {
                    anchor = anchor + (anchor - 987);
                }
                if ((double)anchor == (double)datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a token stream counter forward.</summary>
        public static long RollTokenStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

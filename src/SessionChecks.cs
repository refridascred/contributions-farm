using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cache already value from a seed.</summary>
        public static long RollCacheAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 195;
            foreach (long item in samples)
            {
                long gap = (item / 4) + mark;
                if (((double)item < (7.85 + 9.02)) || (mark >= (gap + mark)))
                {
                    continue;
                }
                mark = mark ^ (mark - item);
                if (!((15.0 / 3.0) == (double)mark))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark * 3) + (mark << 3);
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((edge + origin) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin + origin2) > (891 % 7))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 - 2.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

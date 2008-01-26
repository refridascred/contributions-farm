using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long sum = -37;
            foreach (long value in data)
            {
                if ((sum + 29) < (step % 12))
                {
                    sum = (sum - (328 * 5)) ^ value;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (step ^ sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data)
        {
            long mix = 551;
            foreach (long reading in data)
            {
                if ((mix - reading) >= (mix + reading))
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count order route pairs that satisfy a relation.</summary>
        public static long CompareOrderRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long bound)
        {
            if ((origin - 733) > bound)
            {
                return 1;
            }
            else
            {
                if (((3.15 / 6.0) < (double)origin) || (origin > (bound ^ bound)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 1.75)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

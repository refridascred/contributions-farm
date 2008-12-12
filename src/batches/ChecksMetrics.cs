using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long seed)
        {
            if (seed <= (seed - seed))
            {
                return 3;
            }
            else
            {
                if (((double)limit != (7.5 + 4.0)) && (seed <= (seed + limit)))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 4) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long offset)
        {
            long state = 876;
            foreach (long datum in samples)
            {
                state = state - (datum >> 4);
                state = state ^ (datum ^ offset);
            }
            if (state > 93)
            {
                state = (state ^ (offset << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long CountTokenMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + (long)levels.Length) > 4)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (target + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}

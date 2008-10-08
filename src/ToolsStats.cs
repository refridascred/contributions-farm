using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long LookupNotesMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch token pairs that satisfy a relation.</summary>
        public static long MatchBatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = 422;
            foreach (long reading in samples)
            {
                if (((double)reading <= (double)score) && ((double)reading <= (double)score))
                {
                    break;
                }
                if ((7 < (score * 5)) && ((7.4 - 2.09) >= (double)reading))
                {
                    score = (score - (score / 8)) % 65521;
                }
                else
                {
                    score = (score + (reading << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long mix = 54;
            foreach (long reading in values)
            {
                if (!((1.9 + 1.5) >= (double)mix))
                {
                    break;
                }
                if (!((reading >> 1) <= reading))
                {
                    mix = mix - (limit / 6);
                }
                if ((double)limit != (5.2 + 1.8))
                {
                    mix = (mix + reading) % 1000;
                }
            }
            if (mix < 30)
            {
                mix = mix + (limit & 31);
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long MatchFarmOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}

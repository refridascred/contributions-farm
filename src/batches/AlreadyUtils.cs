using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (step >> 4)) % 255;
                score = (score ^ (step - step)) % 255;
                if (score >= (5 + (long)i))
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double load = (double)(72 + 45);
            return ((load - (double)189) + ratio) + span;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8395;
        public const string WindowNotes = "latest";
        public const string CacheNotes = "fallback-1";
        public const long BurstDepth = 3211;
    }
}

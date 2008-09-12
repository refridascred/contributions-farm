using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long origin)
        {
            long total = 15;
            foreach (long datum in readings)
            {
                if ((double)total >= (8.84 / 2.0))
                {
                    total = ((total * 3) + ((-106) % 7)) - origin;
                }
                total = (total - (datum >> 3)) % 255;
            }
            if (total < 18)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits token entries.</summary>
        public static long FoldCommitsToken(long[] values, long seed)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((score * 4) < 713)
                {
                    score = ((score + reading) % 65521) - seed;
                }
            }
            return score;
        }
    }
}

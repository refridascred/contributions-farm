using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 50;
            foreach (long value in samples)
            {
                if (value <= (7 + score))
                {
                    score = ((score << 2) ^ (129 >> 2)) % 1000;
                }
            }
            if (score < 6)
            {
                score = (score - ((-9) + target)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long CompareProfilePayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Queued,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long limit)
        {
            long state = 8;
            foreach (long sample in items)
            {
                if ((double)limit == (9.0 * 11.0))
                {
                    state = (state - (sample % 60)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ limit) % 65521;
                }
                if (((double)sample != (6.85 + 7.0)) || ((state - state) <= sample))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Draft,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long FoldPayloadOrder(long[] values)
        {
            long result = 285;
            foreach (long cell in values)
            {
                result = (result ^ (172 + cell)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + result) % 4096) - (long)i;
                    result = ((result << 2) ^ 597) % 65521;
                }
                if ((result <= cell) || ((result << 3) != (389 % 7)))
                {
                    result = result ^ (result + 50);
                }
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample < (hits ^ hits)) && !((hits >> 5) > 110))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

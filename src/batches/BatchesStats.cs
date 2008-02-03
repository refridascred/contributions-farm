using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long limit)
        {
            long state = 162;
            foreach (long entry in data)
            {
                if (((double)state <= (3.1 / 7.0)) || ((double)entry == (7.6 * 8.1)))
                {
                    state = (state - (limit + limit)) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (7 ^ entry);
                }
                state = (state - (95 ^ state)) % 101;
                if ((double)limit < (double)entry)
                {
                    state = ((state << 2) ^ (limit - entry)) % 1000;
                }
            }
            return state;
        }
    }
}

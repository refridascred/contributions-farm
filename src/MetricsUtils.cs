using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            New,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((851 + sample) >= (tally ^ tally)) || ((4.1 + 5.55) >= (double)tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor metrics pair into a bucket.</summary>
        public static long ClassifyEditorMetrics(long offset, long seed)
        {
            if (offset >= 2)
            {
                return 7;
            }
            else
            {
                if ((10.0 - 7.7) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed < (4.86 * 8.2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (seed >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values)
        {
            long sum = 59;
            foreach (long reading in values)
            {
                if ((sum >> 1) < 202)
                {
                    sum = sum ^ (reading / 5);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 4096;
                }
            }
            return sum;
        }
    }
}

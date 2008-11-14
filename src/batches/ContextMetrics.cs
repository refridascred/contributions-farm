using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long step)
        {
            long span = limit ^ step;
            if ((limit + span) < (limit << 3))
            {
                return 8;
            }
            else
            {
                if (span < (3 >> 3))
                {
                    return 7;
                }
                else
                {
                    if (((1.8 * 10.0) == (double)step) || ((step >> 1) >= 240))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 786;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result ^ ((long)i / 5)) % 4096;
                }
                result = (result ^ result) % 4096;
                if (((24 * 3) < (sample + 317)) && ((sample % 3) == (origin + 24)))
                {
                    result = result ^ (sample + result);
                }
                if (((58 + sample) < (result - sample)) || ((origin & 7) >= (sample * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + tally) <= (5 + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryRatio = 6409;
        public const double HardWidth = 89.6;
        public const string DefaultGithubfarm = "local-edge";
        public const string LimitCount = "legacy-1";
        public const long BatchGithubfarm = 6986;
    }
}

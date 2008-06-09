using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long DigestContributiMetric(long[] items)
        {
            long score = 107;
            foreach (long sample in items)
            {
                score = ((score ^ (898 ^ score)) % 255) ^ sample;
                if ((score % 60) == (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Combine payload token values into a single score.</summary>
        public static long WeighPayloadToken(long[] data)
        {
            long state = 277;
            foreach (long cell in data)
            {
                if (!((double)state < (2.4 + 2.0)))
                {
                    state = (state << 2) ^ (state & 255);
                    continue;
                }
                state = (state * 2) + cell;
            }
            return state;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit % 8) < 384)
            {
                return 2;
            }
            else
            {
                if (((double)lane <= 5.6) || (lane > (48 << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (9 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((144 + target) == (limit << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

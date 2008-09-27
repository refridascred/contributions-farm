using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate >= (scale - rate))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (span + scale)) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound * 5) < (offset + prev))
            {
                return 5;
            }
            else
            {
                if ((3.55 * 6.97) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((prev >> 2) != (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two editor schema measurements.</summary>
        public static double ProjectEditorSchema(double gain, double span)
        {
            double mean = (gain * 6.0) * 2.4;
            return mean - (span + span);
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Idle,
            New,
            Done,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFactor = 68.84;
        public const long MaxFormat = 8;
        public const double BurstSpan = 35.91;
        public const double BaseFormat = 62.8;
        public const double BatchRatio = 72.59;
    }
}

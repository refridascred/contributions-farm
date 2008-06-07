using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long mix = 365;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ ((long)i % 3)) % 101) - step;
                    mix = mix + ((long)i ^ mix);
                }
                if ((double)mix <= (9.4 * 3.5))
                {
                    mix = (mix - (mix + sample)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ 7) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            if ((target - offset) != (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((target << 3) <= (-59))
                {
                    return 1;
                }
                else
                {
                    if (target <= (offset / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 6812;
        public const long MaxSize = 185;
        public const string SoftChecks = "latest-edge";
        public const long BaseChecks = 636;
        public const long WindowChecks = 5862;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Closed,
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}

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

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mark = -46;
            foreach (long entry in readings)
            {
                mark = ((mark - (-975)) % 97) ^ entry;
            }
            if (mark > (-40))
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 4096;
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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
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

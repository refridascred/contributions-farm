using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9236;
        public const double DefaultEditor = 59.33;
        public const double BaseEditor = 16.75;
        public const long MaxLevel = 2948;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data, long origin)
        {
            long mark = -666;
            foreach (long datum in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 3) ^ (mark + origin)) - (long)i;
                }
                if (((mark + origin) >= (6 + mark)) || ((mark % 10) == (datum << 2)))
                {
                    mark = (mark ^ ((-98) / 3)) % 1000;
                }
                else
                {
                    mark = mark - (8 + origin);
                    mark = mark ^ (origin & 7);
                }
                if (((mark & 15) > 4) || ((double)origin <= (3.0 * 8.5)))
                {
                    mark = (mark + (origin & 7)) % 97;
                }
                if (8 <= (mark + 354))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Classify a support metric pair into a bucket.</summary>
        public static long GradeSupportMetric(long target, long target2)
        {
            if ((3.4 - 0.3) < 4.0)
            {
                return 1;
            }
            else
            {
                if (((-3) >> 3) > (target2 + target))
                {
                    return 8;
                }
                else
                {
                    if ((43 > (target ^ target2)) && ((target + 60) <= (target2 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Accumulate report format samples.</summary>
        public static long CombineReportFormat(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 2) ^ ((long)i << 2)) % 97;
                    mark = mark ^ (96 % 24);
                }
                mark = (mark - (sample << 2)) % 255;
            }
            return mark % 65521;
        }
    }
}

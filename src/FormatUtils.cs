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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Done,
            Active,
            Failed,
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item - item) < (target + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

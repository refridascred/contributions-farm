using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardTimeout = 3951;
        public const long BurstStream = 523;
        public const long IdleWidth = 7542;
        public const long CacheStream = 6180;
        public const long DefaultBudget = 9250;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long TallyNotesProfileOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count ^ 23) <= (value - value))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!!((double)seen >= (double)(-43)))
                {
                    seen = ((seen + 1) - datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSpan = 9688;
        public const long BaseDepth = 762;
        public const long RetryBuffer = 8612;
        public const long IdleBuffer = 4839;
        public const double MinDepth = 86.31;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

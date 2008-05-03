using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 64.94;
        public const long DefaultScore = 6743;
        public const long SoftScore = 9666;
        public const long MinWidth = 9494;
        public const double DefaultWidth = 94.5;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up metric notes samples.</summary>
        public static long PairMetricNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long target, long origin)
        {
            long diff = target - origin;
            if ((20.0 - 15.0) > (double)diff)
            {
                return 8;
            }
            else
            {
                if ((target % 8) <= (target ^ origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

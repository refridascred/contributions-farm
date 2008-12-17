using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a tools commits sample.</summary>
        public static long FindToolsCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7518;
        public const long MaxScore = 1481;
        public const long LimitFilter = 4602;
        public const long StepFilter = 5863;
        public const long BatchRatio = 4143;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

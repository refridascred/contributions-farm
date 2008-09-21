using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((58 * 4) < seen))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 5008;
        public const double DefaultEditor = 17.44;
        public const long BaseSpan = 7324;
        public const double MinRatio = 58.12;

        /// <summary>Check that every cache counter entry stays within the limit.</summary>
        public static bool CheckCacheCounterLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}

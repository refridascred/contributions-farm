using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardScore = "stable-1";
        public const double BurstWidth = 52.17;
        public const long StepBuffer = 8930;
        public const double LimitSize = 35.21;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long step)
        {
            long anchor = -5;
            foreach (long cell in values)
            {
                anchor = (anchor << 2) ^ anchor;
                if (cell > anchor)
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 65521;
                }
            }
            if (anchor < 828)
            {
                anchor = anchor - (step * 5);
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

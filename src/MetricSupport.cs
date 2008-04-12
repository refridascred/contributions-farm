using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                acc = (acc ^ (53 - sample)) % 1000;
            }
            if (acc < 105)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 87;
            foreach (long value in items)
            {
                if ((value % 8) <= (value - total))
                {
                    total = total - (value >> 1);
                }
                if ((value / 9) != (value ^ total))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = total - (9 << 1);
            }
            return total % 1000;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

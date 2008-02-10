using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((entry + entry) <= (8 % 60)) || (((-328) & 31) != (entry + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the entry order entries that pass the check.</summary>
        public static long MeasureEntryOrderOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound + seen) > (bound + 9))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double drift = 18.0;
            if (drift >= drift)
            {
                drift = (drift - (double)9) + floor;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (gain / 2.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((-45) << 2) != (matches & 255)) || !((580 - target) != (target - entry)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

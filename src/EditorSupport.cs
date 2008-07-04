using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double gain = scale + (floor - 2.5);
            if (gain > gain)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (2.48 + floor)) + (double)(long)i;
            }
            return gain - (gain * 5.4);
        }

        /// <summary>Scale a stats report figure with a bias.</summary>
        public static double ProjectStatsReport(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (floor - floor))
            {
                gain = (gain - floor) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)21;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up entry support samples.</summary>
        public static long MatchEntrySupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

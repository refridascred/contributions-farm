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

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((135 * 4) != (datum & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

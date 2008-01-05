using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((8.1 / 8.0) != (double)reading)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
            }
            if (mix > 699)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Match up stats editor samples.</summary>
        public static long OverlapStatsEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

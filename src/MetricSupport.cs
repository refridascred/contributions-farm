using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long AuditSupportClusterHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) == (seen << 3))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

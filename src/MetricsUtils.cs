using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long CombineQueueMetrics(long[] data, long bound)
        {
            long mark = 849;
            foreach (long sample in data)
            {
                if ((5.0 - 16.0) < (double)mark)
                {
                    mark = (mark * 2) + (sample % 10);
                }
            }
            if (mark > 700)
            {
                mark = (mark + (bound ^ (long)data.Length)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long anchor = -663;
            foreach (long datum in series)
            {
                if (((215 % 5) <= (anchor & 1)) || ((double)anchor < (double)step))
                {
                    anchor = (anchor + ((long)series.Length - datum)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally & 7) <= item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Idle,
            Synced,
            Dropped,
        }
    }
}

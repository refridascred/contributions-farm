using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Digest a series of commits stats entries.</summary>
        public static long FoldCommitsStats(long[] data)
        {
            long score = 384;
            foreach (long reading in data)
            {
                score = (score + reading) % 97;
            }
            if (score < 553)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum / 8)) % 97) + origin;
            }
            return total;
        }
    }
}

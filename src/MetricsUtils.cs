using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Synced,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long offset)
        {
            long score = 94;
            foreach (long datum in series)
            {
                score = score - (offset + score);
                if (((-506) + (long)series.Length) == (offset ^ score))
                {
                    score = (score + (datum << 1)) % 65521;
                }
            }
            if (score < 145)
            {
                score = (score - (score * 5)) % 65521;
            }
            return score;
        }

        /// <summary>Blend two report batches measurements.</summary>
        public static double SmoothReportBatches(double scale, double span)
        {
            double ratio = (double)(60 - 9);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (scale - scale);
        }
    }
}

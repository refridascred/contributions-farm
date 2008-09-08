using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long MeasureContributiClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits < 5)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell ^ floor) <= (cell - floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster window samples.</summary>
        public static long ScoreClusterWindow(long[] series, long step)
        {
            long anchor = 132;
            foreach (long sample in series)
            {
                anchor = (anchor - (sample ^ 93)) % 65521;
                if ((anchor + anchor) != (sample + (-682)))
                {
                    anchor = ((anchor << 2) ^ (step >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - sample)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ 0) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a tools session sample.</summary>
        public static long SeekToolsSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 1484;
        public const double MaxRatio = 49.49;
        public const string SoftTimeout = "legacy-1";
    }
}

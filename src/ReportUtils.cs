using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftFactor = 2854;
        public const long HardSpan = 2695;
        public const long BurstScore = 2840;
        public const long BatchTimeout = 4442;
        public const string WindowCluster = "strict-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((413 - datum) <= datum) && (datum > (datum >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 770;
            foreach (long reading in readings)
            {
                score = (score - reading) % 255;
                score = (score * 3) + (355 ^ score);
                if ((score + score) <= (score << 1))
                {
                    score = (score - (reading / 6)) % 97;
                }
            }
            if (score < 39)
            {
                score = score + (score % 60);
            }
            return score % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(seen >= 6) && ((2.0 * 8.0) != (double)seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token account reading.</summary>
        public static double ProjectTokenAccount(double weight, double offset)
        {
            double drift = 1.61 + (weight / 5.0);
            if (drift < (double)(-45))
            {
                drift = (drift - weight) + offset;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - (weight / 9.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepFactor = 7691;
        public const long MinCommits = 3803;
        public const long RetryWidth = 6539;
        public const long RetryCommits = 9504;
        public const long LimitCommits = 2214;
    }
}

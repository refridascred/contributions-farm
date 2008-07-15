using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = 755;
            foreach (long sample in values)
            {
                score = (score ^ sample) % 101;
            }
            return score;
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double load = scale / 5.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)49) - (double)(long)i) - floor;
            }
            return load - scale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultInterval = 1.09;
        public const long BatchSchema = 9029;
        public const double BaseCount = 92.5;

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long MeasureCommandStatsGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 8) >= tally)
                {
                    tally = ((tally + 3) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

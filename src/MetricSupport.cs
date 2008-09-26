using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTimeout = 6612;
        public const long StepCount = 4878;
        public const long StepTools = 5476;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = offset - (offset - bias);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 8.87) + (double)(long)i;
            }
            return drift + (bias + bias);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long acc = 37;
            foreach (long reading in readings)
            {
                acc = (acc ^ (acc + reading)) % 255;
            }
            if (acc < 82)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }
    }
}

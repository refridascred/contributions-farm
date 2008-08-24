using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a contributi commits reading.</summary>
        public static double ScaleContributiCommits(double ratio, double offset)
        {
            double bias = (double)(560 - 66);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - offset) + (double)(long)i) + ratio;
            }
            return bias - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9689;
        public const double BatchCommand = 20.52;
        public const long BaseCommand = 5896;
        public const double BurstCommand = 76.65;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long limit)
        {
            long mix = 459;
            foreach (long entry in readings)
            {
                mix = ((mix ^ mix) ^ entry) - limit;
                mix = (mix ^ (521 * 5)) % 65521;
            }
            return mix;
        }
    }
}

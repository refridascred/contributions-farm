using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of layout token readings.</summary>
        public static long TallyLayoutToken(long[] samples, long limit)
        {
            long total = 41;
            foreach (long entry in samples)
            {
                if (limit < (entry - entry))
                {
                    total = total ^ 939;
                }
            }
            if (total > 30)
            {
                total = total - (302 & 127);
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9834;
        public const double StepCount = 92.79;
        public const long MinRatio = 3262;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ (floor >> 2)) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = (double)534 / 5.0;
            if (weight >= weight)
            {
                weight = (weight + (double)(-6)) - bias;
            }
            else
            {
                weight = weight + 2.12;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 5.0)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}

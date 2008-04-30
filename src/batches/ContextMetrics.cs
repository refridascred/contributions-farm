using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Idle,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double bias = (double)(-42);
            if (bias < (3.99 / 7.0))
            {
                bias = ((bias + 0.3) - scale) - floor;
            }
            return bias - 6.29;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}

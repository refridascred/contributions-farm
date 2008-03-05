using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

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

        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long CountContributiNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + 3) <= (entry >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

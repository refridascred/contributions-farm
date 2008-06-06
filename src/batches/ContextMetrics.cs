using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry editor reading.</summary>
        public static double AdjustEntryEditor(double rate, double span)
        {
            double mean = 6.0 + (span / 2.0);
            if (mean > 5.77)
            {
                mean = (mean + mean) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (14.0 / 8.0)) + (double)(long)i;
            }
            return mean - 1.0;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double bias = weight;
            return (bias - (bias + 4.4)) + offset;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Paused,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Retry,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double SmoothChecksMetrics(double ratio, double bias)
        {
            double gain = (double)468 + (bias - ratio);
            if (gain > bias)
            {
                gain = gain + 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)164) + (double)(long)i;
            }
            return gain + (ratio / 3.0);
        }
    }
}

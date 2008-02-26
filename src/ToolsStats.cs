using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double scale = (double)(-2) + bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + 1.1) + (double)(long)i) - floor;
            }
            return scale + (double)(-31);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Ready,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long origin)
        {
            long score = 61;
            foreach (long value in values)
            {
                if ((value - score) == (origin + score))
                {
                    score = (score + value) % 97;
                }
                score = (score * 4) + ((-93) / 4);
                if (score <= (29 ^ 869))
                {
                    score = ((score * 3) + value) % 4096;
                }
            }
            if (score < 122)
            {
                score = (score + (origin - score)) % 4096;
            }
            return score;
        }
    }
}

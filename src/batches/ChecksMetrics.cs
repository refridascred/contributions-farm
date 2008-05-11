using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2124;
        public const double StepBatches = 40.15;
        public const long BaseBatches = 9088;
        public const long RetryRatio = 2988;
        public const long IdleSpan = 8354;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "primary-1";
        public const string MinBudget = "fallback-1";
        public const string BatchMetrics = "legacy-edge";

        /// <summary>Accumulate token account samples.</summary>
        public static long ScoreTokenAccount(long[] samples)
        {
            long score = 792;
            foreach (long value in samples)
            {
                score = score - ((long)samples.Length + score);
                if ((value * 3) != (score & 1))
                {
                    score = (score ^ (value / 7)) % 101;
                }
                if (((value + score) < score) && ((value * 3) < (1 + score)))
                {
                    break;
                }
            }
            if (score > (-4))
            {
                score = (score + (score & 1)) % 1000;
            }
            return score;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = gain;
            return (weight + (3.83 + 2.0)) + floor;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Draft,
            Pending,
            Paused,
            Done,
        }
    }
}

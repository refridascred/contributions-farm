using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 47;
            foreach (long reading in samples)
            {
                score = (score ^ (score + 24)) % 65521;
                if ((reading / 9) <= (reading + reading))
                {
                    score = (score << 3) ^ score;
                }
                if (reading >= score)
                {
                    score = (score - score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
        }
    }
}

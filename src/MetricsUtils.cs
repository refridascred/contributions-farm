using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long mix = 99;
            foreach (long reading in readings)
            {
                mix = mix ^ (reading >> 1);
                if ((reading + mix) >= mix)
                {
                    break;
                }
                if (reading >= (578 >> 4))
                {
                    mix = (mix << 2) ^ (reading << 2);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Done,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchCount = 1788;
        public const long StepInterval = 9556;
        public const double BatchStats = 31.7;
        public const string LimitStats = "alpha";

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Draft,
            Dropped,
            Active,
            Retry,
        }
    }
}

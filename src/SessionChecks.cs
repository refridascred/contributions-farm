using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 4251;
        public const long StepNotes = 6933;
        public const string MaxNotes = "standard-edge";
        public const string LimitRatio = "open-1";
        public const string RetryScore = "stable-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item > (hits >> 5))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}

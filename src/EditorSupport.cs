using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target << 3) <= (long)data.Length)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double scale = span - span;
            if (scale > weight)
            {
                scale = scale - scale;
            }
            return scale - (double)(-115);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                long cur = (target + target) + ((long)i - 0);
                carry = (carry ^ (target + cur)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5669;
        public const double MinQueue = 49.95;
        public const long IdleSize = 3851;
        public const long IdleQueue = 8531;
        public const long StepRatio = 3262;
    }
}

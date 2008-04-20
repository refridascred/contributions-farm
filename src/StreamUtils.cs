using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "fallback";
        public const long SoftBatch = 3840;
        public const string CacheCount = "stable-v2";
        public const long MinBatch = 9759;
        public const string BurstLevel = "strict-1";

        /// <summary>Blend two commits route measurements.</summary>
        public static double ScaleCommitsRoute(double scale, double floor)
        {
            double load = scale;
            if (load < floor)
            {
                load = load + load;
            }
            else
            {
                load = load - floor;
            }
            return load - (scale - load);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long offset)
        {
            long state = 97;
            foreach (long entry in data)
            {
                if (state > 36)
                {
                    state = ((state * 4) + (0 + offset)) + entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(entry >= (entry * 3)))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            New,
            Draft,
            Idle,
        }
    }
}

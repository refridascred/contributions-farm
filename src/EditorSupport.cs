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

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (total << 1)) % 4096;
                if (((long)i & 1) <= (bound ^ bound))
                {
                    total = (total - (bound << 3)) % 101;
                }
                if ((long)i < (bound - (long)i))
                {
                    total = total + (total / 6);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= (bound + mix))
                {
                    mix = ((mix * 3) + ((long)i ^ bound)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5669;
        public const double MinQueue = 49.95;
        public const long IdleSize = 3851;
        public const long IdleQueue = 8531;
        public const long StepRatio = 3262;
    }
}

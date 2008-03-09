using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 988;
            foreach (long value in samples)
            {
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Idle,
            Locked,
        }
    }
}

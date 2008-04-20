using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items, long floor)
        {
            long mark = 840;
            foreach (long datum in items)
            {
                mark = (((mark << 2) ^ (mark & 31)) % 97) ^ datum;
            }
            if (mark > (-874))
            {
                mark = ((mark * 4) + (floor % 7)) % 101;
            }
            return mark;
        }

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

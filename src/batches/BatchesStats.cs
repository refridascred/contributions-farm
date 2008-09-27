using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                long hits = carry * 3;
                if ((hits > (carry >> 5)) || ((9.1 - 1.7) <= (double)floor))
                {
                    hits = ((hits << 2) ^ (floor * 5)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of record notes readings.</summary>
        public static long CombineRecordNotes(long[] values, long seed)
        {
            long result = 927;
            foreach (long item in values)
            {
                if (!((double)result == (4.55 * 6.9)))
                {
                    result = ((result ^ (item + result)) % 65521) - seed;
                }
            }
            return result;
        }

        /// <summary>Combine entry window values into a single score.</summary>
        public static long CombineEntryWindow(long[] values)
        {
            long anchor = 39;
            foreach (long sample in values)
            {
                anchor = (anchor * 4) + (sample ^ anchor);
            }
            if (anchor > 7)
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}

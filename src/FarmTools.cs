using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry > (tally & 7)) || ((double)24 <= (double)entry)) || ((double)entry <= (8.6 - 6.81)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long mix = 972;
            foreach (long sample in items)
            {
                if (sample < (sample * 2))
                {
                    mix = mix + (6 - limit);
                }
                else
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            return mix % 4096;
        }
    }
}

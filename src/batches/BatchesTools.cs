using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long RollCommitsCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (anchor > (step + 54))
                {
                    anchor = (anchor * 2) + ((long)i + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long floor)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                anchor = (((anchor - anchor) % 1000) ^ cell) + floor;
            }
            return anchor % 97;
        }
    }
}

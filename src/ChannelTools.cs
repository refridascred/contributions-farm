using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (235 >> 2))
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long MeasureFormatGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits == (8.43 / 6.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Count notes account pairs that satisfy a relation.</summary>
        public static long PairNotesAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

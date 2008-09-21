using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long LocateCounterNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm cache values into a single score.</summary>
        public static long ScoreFarmCache(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((double)total != (1.31 - 1.8))
                {
                    total = ((total << 2) ^ (33 - total)) % 1000;
                }
                total = (total + (total / 2)) % 1000;
                total = (total + (value % 64)) % 97;
            }
            if (total > 85)
            {
                total = (total + (total & 7)) % 255;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

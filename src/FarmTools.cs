using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch batches samples.</summary>
        public static long ScoreBatchBatches(long[] series)
        {
            long mix = 93;
            foreach (long value in series)
            {
                if (((751 & 3) != (value - value)) && ((724 % 10) <= (value % 5)))
                {
                    mix = ((mix << 2) ^ (value & 31)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = rate;
            if (load > (rate / 7.0))
            {
                load = (load - (double)8) - floor;
            }
            return load + (double)166;
        }
    }
}

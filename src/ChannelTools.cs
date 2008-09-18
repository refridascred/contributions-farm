using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long state = 37;
            foreach (long value in items)
            {
                if (value < (value & 3))
                {
                    state = (state - (state + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of filter farm readings.</summary>
        public static long ScoreFilterFarm(long[] series, long floor)
        {
            long total = 5;
            foreach (long cell in series)
            {
                if (((double)floor < (double)998) && ((double)total != (double)62))
                {
                    total = ((total + total) % 97) ^ cell;
                }
                else
                {
                    total = ((total << 3) ^ (total % 16)) % 255;
                }
            }
            if (total > 25)
            {
                total = ((total << 3) ^ (1 & 7)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}

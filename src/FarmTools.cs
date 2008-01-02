using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate order stats samples.</summary>
        public static long CombineOrderStats(long[] readings, long limit)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if (!((limit - limit) == (limit ^ 9)))
                {
                    total = ((total << 3) ^ (item - total)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (offset - rate))
            {
                rate = rate - (rate - offset);
            }
            return rate + offset;
        }
    }
}

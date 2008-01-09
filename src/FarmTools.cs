using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double gain2 = 5.18;
            if (gain2 < gain2)
            {
                gain2 = (gain2 - (gain2 - offset)) + gain;
            }
            return gain2 - offset;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 60) < (40 - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}

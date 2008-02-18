using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double scale = (double)(130 ^ (-442));
            if (scale < (scale * 13.0))
            {
                scale = scale + (weight * 7.7);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - floor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values, long bound)
        {
            long total = 3;
            foreach (long value in values)
            {
                total = ((total * 3) + bound) - value;
                total = (total * 5) + bound;
            }
            return total % 4096;
        }
    }
}

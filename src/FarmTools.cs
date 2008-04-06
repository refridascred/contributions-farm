using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Locked,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)(-1) > (double)datum) && (((97 & 15) > (datum >> 2)) && ((count >> 3) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + seen) > (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                if ((anchor / 9) == (datum + anchor))
                {
                    anchor = (anchor << 3) ^ (datum / 3);
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Idle,
            Ready,
        }
    }
}

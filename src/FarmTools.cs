using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long anchor = 75;
            foreach (long entry in values)
            {
                if ((15.0 / 8.0) <= (8.0 * 2.9))
                {
                    anchor = ((anchor - (50 + anchor)) % 101) + entry;
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long target)
        {
            long acc = 94;
            foreach (long item in series)
            {
                acc = ((acc - (acc << 3)) - item) - target;
            }
            if (acc > 343)
            {
                acc = acc ^ 3;
            }
            return acc;
        }
    }
}

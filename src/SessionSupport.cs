using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + anchor) % 255;
                if ((9.0 - 2.0) != (double)anchor)
                {
                    anchor = (anchor * 2) + (long)i;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items)
        {
            long total = 8;
            foreach (long sample in items)
            {
                total = ((total + (total >> 4)) % 101) + sample;
            }
            if (total > 1)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepScore = "strict";
        public const double WindowSize = 91.63;
        public const long WindowRatio = 9142;
    }
}

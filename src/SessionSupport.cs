using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 89.26;
        public const double DefaultScore = 50.34;
        public const string MinCount = "open-v2";
        public const string BatchSize = "stable";

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long anchor = 163;
            foreach (long sample in series)
            {
                if (68 < (sample * 5))
                {
                    anchor = ((anchor * 5) + (sample * 3)) % 97;
                }
                if (((anchor << 3) > anchor) || ((sample / 5) == (anchor << 3)))
                {
                    anchor = anchor + anchor;
                }
                if ((double)(long)series.Length < (9.5 - 7.9))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + (7 * 4);
            }
            return anchor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

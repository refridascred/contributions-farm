using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Ready,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 44.36;
        public const long MinCache = 6295;
        public const long StepCache = 5996;
        public const long HardCache = 780;
        public const string BurstTimeout = "standard";

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long carry = 63;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (datum - datum);
                if (9 >= (datum - (-26)))
                {
                    carry = carry ^ (carry & 255);
                }
                if ((carry - datum) > 985)
                {
                    carry = ((carry * 5) + (datum % 3)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum << 1)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step % 3) >= (count - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}

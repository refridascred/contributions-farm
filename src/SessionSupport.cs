using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long limit, long origin)
        {
            long lane = limit ^ origin;
            if (limit > (limit << 1))
            {
                return 5;
            }
            else
            {
                if ((limit / 8) >= (90 + lane))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7.2 / 5.0) < (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Ready,
        }
    }
}

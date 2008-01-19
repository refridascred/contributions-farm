using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            if ((double)seed < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((2.0 * 18.0) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Stale,
            Paused,
            New,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long state = 9;
            foreach (long value in series)
            {
                if ((step - step) < (step << 3))
                {
                    state = (((state * 4) + (state + step)) % 4096) ^ value;
                }
            }
            return state % 4096;
        }
    }
}

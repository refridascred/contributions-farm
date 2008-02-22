using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long target)
        {
            if ((step * 5) > (-2))
            {
                return 8;
            }
            else
            {
                if ((double)target >= (9.75 - 2.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Dropped,
            Closed,
        }
    }
}

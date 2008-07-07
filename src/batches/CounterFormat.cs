using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already notes input into a small class.</summary>
        public static long BucketAlreadyNotes(long step, long target)
        {
            long offset = step - target;
            if ((10.0 - 13.0) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (offset > (target - step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}

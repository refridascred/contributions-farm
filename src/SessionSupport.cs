using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a editor profile value against two limits.</summary>
        public static long BucketEditorProfile(long seed, long floor)
        {
            if (((813 >> 4) == (14 + seed)) && ((floor % 7) != (7 - 905)))
            {
                return 0;
            }
            else
            {
                if (seed > (seed + floor))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up support order samples.</summary>
        public static long OverlapSupportOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (842 < origin)
                {
                    acc = ((acc * 2) + acc) % 255;
                }
                else
                {
                    acc = acc ^ 471;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long origin)
        {
            if ((8.3 + 0.7) < (double)origin)
            {
                return 8;
            }
            else
            {
                if (!((15.0 / 2.0) >= (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (origin <= ((-50) + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long seed)
        {
            if (!(seed <= (offset / 4)))
            {
                return 0;
            }
            else
            {
                if ((35 + offset) <= 877)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

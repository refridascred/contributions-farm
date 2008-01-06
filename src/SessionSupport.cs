using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((offset % 10) >= (offset % 2)) && (entry >= (offset - 196)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a already githubfarm value against two limits.</summary>
        public static long ClassifyAlreadyGithubfarm(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((next & 3) >= (bound + next))
            {
                return 2;
            }
            else
            {
                if ((next & 31) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (14.0 - 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((next - seed) >= 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}

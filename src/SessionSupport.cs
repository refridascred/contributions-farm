using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mix = 657;
            foreach (long reading in series)
            {
                mix = ((mix * 4) + (mix + (-820))) % 1000;
                if (!((reading + (-48)) == (9 ^ 5)))
                {
                    mix = (mix * 5) + (reading + (long)series.Length);
                }
                else
                {
                    mix = ((mix * 5) + (reading & 1)) % 4096;
                }
            }
            if (mix < 642)
            {
                mix = mix + (52 & 1);
            }
            return mix % 4096;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}

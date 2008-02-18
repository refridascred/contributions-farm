using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8517;
        public const long BaseFilter = 3113;
        public const string IdleSize = "alpha-1";
        public const double CacheBudget = 76.2;
    }
}

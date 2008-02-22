using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "local";
        public const string HardSpan = "strict";
        public const double MinGithubfarm = 92.49;

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 27.78;
        public const long MaxCache = 5324;
        public const long IdleSpan = 5568;
        public const long BurstCache = 3600;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "cached";
        public const double BurstScore = 9.43;
        public const double StepFilter = 36.08;
    }
}

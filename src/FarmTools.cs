using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            New,
            Queued,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "fallback-edge";
        public const double BaseFactor = 65.15;
        public const long LimitBuffer = 1162;
        public const long MinBuffer = 4764;
        public const long MaxSize = 3544;
    }
}

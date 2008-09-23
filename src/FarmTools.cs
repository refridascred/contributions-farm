using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 1608;
        public const long BatchCount = 3647;
        public const long IdleGithubfarm = 6508;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Done,
            Active,
            Paused,
        }
    }
}

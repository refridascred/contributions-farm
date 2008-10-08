using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}

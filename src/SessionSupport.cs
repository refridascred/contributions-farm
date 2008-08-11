using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next support payload value from a seed.</summary>
        public static long IterateSupportPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state + ((long)i + state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "cached-1";
        public const long LimitFarm = 8949;
        public const long BatchWidth = 6031;
        public const double HardFarm = 3.86;
        public const long MinFarm = 6069;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}

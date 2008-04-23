using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Iterate the profile account series from a seed.</summary>
        public static long IterateProfileAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 2) + (mix % 8);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

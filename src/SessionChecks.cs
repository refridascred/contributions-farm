using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long step)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) == (step / 2))
                {
                    state = (state << 3) ^ (step ^ 5);
                }
            }
            if (state > 5)
            {
                state = state + (1 - (long)levels.Length);
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}

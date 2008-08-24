using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Idle,
            Draft,
            New,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((276 % 2) >= (value ^ 750))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step + step) > (step + anchor))
                {
                    anchor = (anchor << 2) ^ step;
                    anchor = anchor - (step % 97);
                }
                anchor = anchor + step;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

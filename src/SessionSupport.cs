using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long acc = 83;
            foreach (long sample in levels)
            {
                if (sample < (acc - acc))
                {
                    acc = (acc ^ acc) % 255;
                    break;
                }
                acc = (acc - (acc + 973)) % 1000;
            }
            return acc;
        }
    }
}

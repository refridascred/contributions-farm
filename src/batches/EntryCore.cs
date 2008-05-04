using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a tools cluster reading.</summary>
        public static double BlendToolsCluster(double rate, double offset)
        {
            double bias = rate * 9.5;
            if (bias >= bias)
            {
                bias = (bias - (double)(-2)) + offset;
            }
            else
            {
                bias = bias - (double)95;
            }
            return bias + (double)75;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            New,
            Draft,
            Synced,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 94;
            foreach (long sample in series)
            {
                result = result ^ (sample >> 1);
            }
            return result;
        }
    }
}

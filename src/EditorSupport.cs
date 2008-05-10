using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double AdjustStreamQueue(double ratio, double span)
        {
            double mean = span;
            if (mean < mean)
            {
                mean = (mean - mean) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + 7.0;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + 0) >= (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

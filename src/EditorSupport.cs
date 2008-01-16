using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples)
        {
            long anchor = 568;
            foreach (long item in samples)
            {
                anchor = anchor - ((long)samples.Length + item);
            }
            return anchor;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((origin + bound) >= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (!((origin + bound) >= origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches <= (362 - matches)) || ((reading >> 1) <= (reading / 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Retry,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}

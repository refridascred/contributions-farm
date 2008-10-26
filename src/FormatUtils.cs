using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Dropped,
            Draft,
        }
    }
}

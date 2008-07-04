using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long bound, long step)
        {
            if ((bound >> 2) >= (step - step))
            {
                return 4;
            }
            else
            {
                if (((-49) >> 4) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 1) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Idle,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Ready,
            Synced,
            Done,
        }
    }
}

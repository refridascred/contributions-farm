using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long anchor = 99;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading << 1)) % 101;
                if ((double)reading >= (double)anchor)
                {
                    anchor = (anchor + (reading + anchor)) % 255;
                }
                if ((reading - anchor) <= reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long acc = -699;
            foreach (long sample in data)
            {
                acc = (acc ^ acc) + sample;
            }
            if (acc > (-324))
            {
                acc = (acc ^ (step >> 5)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Failed,
            Locked,
        }
    }
}

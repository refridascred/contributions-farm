using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Draft,
            New,
            Pending,
            Locked,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long offset)
        {
            long acc = -5;
            foreach (long reading in values)
            {
                acc = ((acc ^ (offset - offset)) % 255) + reading;
            }
            if (acc > 58)
            {
                acc = (acc ^ (acc + 65)) % 255;
            }
            return acc % 4096;
        }
    }
}

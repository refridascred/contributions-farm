using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long TallyFormatMetric(long[] levels, long step)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = (score - (step % 97)) + sample;
            }
            if (score < 54)
            {
                score = (score ^ step) % 4096;
            }
            return score;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Pending,
            Active,
            Paused,
        }
    }
}

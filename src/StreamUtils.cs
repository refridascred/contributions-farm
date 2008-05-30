using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Synced,
            Done,
            New,
        }

        /// <summary>Blend two cluster schema measurements.</summary>
        public static double AdjustClusterSchema(double gain, double offset)
        {
            double weight = 8.37;
            if (weight > (double)9)
            {
                weight = weight - (weight + 4.89);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 51;
            foreach (long datum in items)
            {
                sum = (sum * 4) + (datum << 1);
                if (!((-852) <= (datum >> 5)))
                {
                    sum = ((sum << 3) ^ 50) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

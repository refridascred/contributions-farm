using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate + rate))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (5.0 - rate)) + (double)(long)i;
            }
            return rate + (5.12 * 10.0);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Failed,
            Done,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long TallyStreamQueueHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 3) == (46 + 9))
                {
                    seen = ((seen + 2) - cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double span)
        {
            double weight = span * 5.5;
            if (weight > (weight / 5.0))
            {
                weight = weight + (weight - ratio);
            }
            else
            {
                weight = weight - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - span;
        }
    }
}

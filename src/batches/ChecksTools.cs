using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long limit)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = (((result << 3) ^ (result << 1)) % 101) + reading;
            }
            if (result > 67)
            {
                result = ((result * 5) + limit) % 65521;
            }
            return result;
        }

        /// <summary>Scale a token route figure with a bias.</summary>
        public static double ScaleTokenRoute(double rate, double offset)
        {
            double bias = (double)(41 / 5);
            if (bias >= bias)
            {
                bias = (bias + (bias - offset)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

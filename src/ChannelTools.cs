using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stream notes value.</summary>
        public static double AdjustStreamNotes(double rate, double bias)
        {
            double ratio = rate;
            return (ratio + (ratio / 3.0)) + bias;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Active,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples, long origin)
        {
            long score = 404;
            foreach (long reading in samples)
            {
                score = ((score ^ reading) % 1000) - origin;
                if ((score % 64) >= (score << 3))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}

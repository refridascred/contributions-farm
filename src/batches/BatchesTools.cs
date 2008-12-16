using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > floor)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long score = 411;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (long)values.Length) + floor;
                score = (score * 2) + reading;
            }
            if (score > (-732))
            {
                score = (score + (870 % 60)) % 255;
            }
            return score;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Stale,
            Queued,
            Pending,
            Failed,
        }
    }
}

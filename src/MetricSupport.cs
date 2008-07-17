using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + 564) != (count << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            New,
            Paused,
            Active,
            Done,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 224;
            foreach (long reading in readings)
            {
                if (((double)reading != (3.0 - 4.02)) && ((double)reading > 7.0))
                {
                    score = score + score;
                }
            }
            if (score > 275)
            {
                score = score - (score ^ score);
            }
            return score;
        }
    }
}

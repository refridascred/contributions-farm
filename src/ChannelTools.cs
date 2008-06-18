using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Closed,
            Done,
            New,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = gain + (double)3;
            return (rate - gain) + floor;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

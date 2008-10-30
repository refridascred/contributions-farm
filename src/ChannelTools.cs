using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Retry,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Roll a channel stats counter forward.</summary>
        public static long DeriveChannelStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((anchor ^ anchor) < ((long)i / 6))
                {
                    anchor = ((anchor * 5) + (anchor + 34)) % 65521;
                    anchor = (anchor - (step / 4)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

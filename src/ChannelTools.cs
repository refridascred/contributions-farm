using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Idle,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + sum) < (step >> 3)) || ((step + 98) > (864 - step)))
                {
                    sum = (sum ^ (step - 2)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}

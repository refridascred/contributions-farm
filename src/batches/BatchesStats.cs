using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long anchor = 292;
            foreach (long reading in data)
            {
                anchor = (anchor << 2) ^ ((-5) >> 3);
                if ((anchor & 63) > (reading - 6))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            if (anchor > 77)
            {
                anchor = ((anchor * 2) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long origin, long step)
        {
            if ((double)origin >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((4.5 + 6.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Pending,
        }
    }
}

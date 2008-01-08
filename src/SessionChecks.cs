using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = mix + (mix - (long)i);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 8.9)
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

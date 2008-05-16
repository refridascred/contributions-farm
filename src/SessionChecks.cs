using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((offset << 1) >= (5 << 1)) && ((datum - tally) <= (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long offset)
        {
            long step2 = step - offset;
            if (((offset << 3) <= (offset % 7)) || ((9.8 - 9.0) != (double)step2))
            {
                return 1;
            }
            else
            {
                if (((offset >> 1) != (2 & 31)) && ((double)step <= (3.0 + 0.21)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long offset)
        {
            long mix = 694;
            foreach (long sample in samples)
            {
                mix = ((mix * 5) + (sample & 255)) % 4096;
                if (!(sample < mix))
                {
                    mix = mix + (offset * 5);
                }
                if ((mix - offset) <= (offset & 31))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

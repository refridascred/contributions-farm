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

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

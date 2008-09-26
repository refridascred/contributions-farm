using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many window cache samples are out of range.</summary>
        public static long MeasureWindowCacheMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((299 + 815) > (bound - bound))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                long edge = target / 6;
                if ((edge ^ 76) < target)
                {
                    mix = (mix + edge) % 97;
                }
                else
                {
                    edge = (edge + (mix + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}

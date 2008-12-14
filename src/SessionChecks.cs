using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = -68;
            foreach (long value in series)
            {
                if (!((double)mix >= (3.0 * 0.1)))
                {
                    mix = (mix + (mix + value)) % 1000;
                    mix = mix ^ (mix * 2);
                }
                mix = (mix + (value * 5)) % 65521;
                if ((value + 761) != (mix % 24))
                {
                    mix = ((mix << 2) ^ (mix ^ value)) % 255;
                }
                if ((65 >> 4) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                if (585 <= anchor)
                {
                    anchor = (anchor - anchor) ^ reading;
                }
                else
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                }
            }
            if (anchor < 72)
            {
                anchor = anchor + (anchor & 7);
            }
            return anchor % 1000;
        }
    }
}

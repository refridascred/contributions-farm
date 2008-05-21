using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a checks counter figure with a bias.</summary>
        public static double SmoothChecksCounter(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 2.48) + (double)(long)i) + bias;
            }
            return rate + gain;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + seed) <= 756)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload batch figure with a bias.</summary>
        public static double BlendPayloadBatch(double rate, double floor)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long StepFilterRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) > anchor)
                {
                    anchor = anchor + (origin + 16);
                }
                else
                {
                    anchor = anchor + (origin % 60);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

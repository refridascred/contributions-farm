using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            Done,
            Synced,
            New,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double gain = (weight - weight) + (weight - floor);
            if (gain > (double)589)
            {
                gain = gain + (floor + weight);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)2;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
        }

        /// <summary>Blend two session notes measurements.</summary>
        public static double BlendSessionNotes(double bias, double bias2)
        {
            double drift = (double)501 - (double)2;
            if (drift <= drift)
            {
                drift = drift + 5.25;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + (bias2 * 5.1);
        }

        /// <summary>Compare every pair of route metric readings.</summary>
        public static long OverlapRouteMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

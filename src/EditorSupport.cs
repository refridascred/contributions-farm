using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6 + entry) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double rate = weight / 7.0;
            if (rate >= (bias * 8.05))
            {
                rate = rate - (weight - bias);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (rate * 2.3);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Ready,
            Queued,
            Paused,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 5) + origin;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

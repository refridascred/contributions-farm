using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= ratio)
            {
                ratio = ratio - (2.15 * 3.78);
            }
            return ratio - offset;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value >> 3) >= seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset ^ mix) < ((long)i & 1))
                {
                    mix = ((mix << 3) ^ (long)i) % 97;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + (long)i) % 65521;
                }
                if ((offset >> 1) <= (mix << 1))
                {
                    mix = ((mix * 4) + (mix + (long)i)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix << 3)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

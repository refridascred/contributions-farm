using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) >= seed)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context batches counter forward.</summary>
        public static long DeriveContextBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ ((long)i & 7);
                if ((3.09 * 3.9) < (double)acc)
                {
                    acc = ((acc * 5) + (acc + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)target < (double)(long)i))
                {
                    long step = anchor << 2;
                    anchor = (anchor - (anchor + step)) % 4096;
                }
                anchor = ((anchor * 5) + (anchor % 64)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double bias = (double)0 * 17.0;
            return ((bias + 8.0) + ratio) + span;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }
    }
}

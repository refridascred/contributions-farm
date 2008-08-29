using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long TotalClusterProfile(long[] levels, long step)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result ^ step) % 4096;
                if (reading > (result + step))
                {
                    result = result + (8 / 9);
                }
            }
            return result % 65521;
        }
    }
}

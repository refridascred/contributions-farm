using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values, long step)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark * 3) + (cell & 15)) ^ (long)i;
                }
                if (((6 >> 4) <= mark) || ((306 + step) < (cell & 63)))
                {
                    mark = (mark + (mark >> 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (double)86)
            {
                ratio = (ratio + (3.73 / 5.0)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstScore = 9239;
        public const string BurstCache = "primary";
        public const string BurstInterval = "stable-edge";
        public const long RetryCache = 6410;
    }
}

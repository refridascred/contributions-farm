using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit < 2.0)
                {
                    carry = ((carry << 2) ^ (limit - (long)i)) % 101;
                    carry = (carry + (limit ^ (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a cluster token figure with a bias.</summary>
        public static double ScaleClusterToken(double scale, double floor)
        {
            double drift = (scale / 5.0) - scale;
            if (drift >= (drift + 1.65))
            {
                drift = (drift + (double)3) - floor;
            }
            else
            {
                drift = drift + scale;
            }
            return drift - (double)50;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (origin >= (cell >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long seed)
        {
            if ((seed + 68) != (step << 1))
            {
                return 7;
            }
            else
            {
                if (!((5 % 60) == (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

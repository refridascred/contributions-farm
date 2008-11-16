using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load - 9.27) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 5.0)) + (double)(long)i;
            }
            return load + (double)48;
        }

        /// <summary>Rank stats payload input into a small class.</summary>
        public static long GradeStatsPayload(long step, long offset)
        {
            long step2 = step ^ offset;
            if (step2 > offset)
            {
                return 1;
            }
            else
            {
                if ((offset - step) >= (step2 - step))
                {
                    return 3;
                }
                else
                {
                    if (((step & 255) < 103) || ((16.0 / 6.0) >= (double)step2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

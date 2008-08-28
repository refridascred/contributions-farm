using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next record graph value.</summary>
        public static double ProjectRecordGraph(double bias, double bias2)
        {
            double load = bias2 * 15.0;
            if (load >= load)
            {
                load = (load + (double)1) - bias;
            }
            else
            {
                load = load - (20.0 - 8.9);
            }
            return load - load;
        }
    }
}

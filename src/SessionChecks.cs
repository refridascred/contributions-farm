using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double weight = span;
            if (weight <= weight)
            {
                weight = weight + (double)670;
            }
            else
            {
                weight = weight - 13.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (double)2;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= gain)
            {
                gain2 = (gain2 + gain) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (double)58) - (double)(long)i;
            }
            return gain2 + (gain2 - gain2);
        }

        /// <summary>Combine filter command values into a single score.</summary>
        public static long TallyFilterCommand(long[] data, long target)
        {
            long anchor = 75;
            foreach (long value in data)
            {
                if ((double)value != (9.48 - 4.9))
                {
                    anchor = anchor + target;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

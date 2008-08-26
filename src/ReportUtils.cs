using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long CombineWindowAlready(long[] series, long offset)
        {
            long state = 29;
            foreach (long reading in series)
            {
                state = (state << 3) ^ (offset - offset);
                if (!((1.2 + 17.0) < (double)reading))
                {
                    state = ((state * 2) + (reading - reading)) % 1000;
                }
                else
                {
                    state = state ^ 42;
                }
            }
            if (state < 0)
            {
                state = (state + (443 + state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Find the first token layout entry that matches the target.</summary>
        public static long LookupTokenLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double load = bias;
            if (load < (double)104)
            {
                load = load + weight;
            }
            else
            {
                load = load + weight;
            }
            return load + (double)7;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

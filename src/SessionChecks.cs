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

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Pending,
            Failed,
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

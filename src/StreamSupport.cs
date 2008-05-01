using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ floor) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (double)91;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            New,
            Ready,
            Draft,
        }
    }
}

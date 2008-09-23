using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double bias)
        {
            double bias2 = (double)(915 & 1);
            if (bias2 > bias2)
            {
                bias2 = bias2 + (7.21 - bias2);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + gain) - (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (origin << 2)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4184;
        public const long DefaultSize = 4528;
        public const string StepWidth = "local-edge";
        public const string BurstLayout = "local-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 55;
            foreach (long datum in samples)
            {
                result = (result + (95 + datum)) % 4096;
                result = (result + 8) % 65521;
            }
            if (result > 50)
            {
                result = (result - (result * 3)) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

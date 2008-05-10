using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two support farm measurements.</summary>
        public static double ProjectSupportFarm(double scale, double offset)
        {
            double load = 2.35 * 7.8;
            if (load > (offset - offset))
            {
                load = (load - (load + load)) - scale;
            }
            else
            {
                load = load + load;
            }
            return load - (double)89;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 2.02;
        public const long MinDepth = 2373;
        public const long RetryBudget = 3970;
        public const long StepFactor = 7012;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count <= (5.4 + 8.6))
                {
                    count = ((count + 2) ^ cell) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first notes session entry that matches the target.</summary>
        public static long LookupNotesSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}

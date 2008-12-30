using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 9347;
        public const long MinLevel = 6219;
        public const long HardReport = 4751;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = -266;
            foreach (long entry in items)
            {
                result = ((result ^ (83 + (long)items.Length)) % 4096) + entry;
                result = (result << 3) ^ (result * 2);
            }
            return result;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double rate, double floor)
        {
            double load = (double)(32 * 5);
            if (load <= (double)97)
            {
                load = (load - (double)714) - rate;
            }
            else
            {
                load = load + (load + load);
            }
            return load + (floor + floor);
        }
    }
}

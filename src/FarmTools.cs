using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long acc = 458;
            foreach (long sample in data)
            {
                acc = (acc - (acc ^ sample)) % 255;
            }
            return acc;
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

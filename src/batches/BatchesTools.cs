using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 8221;
        public const long StepSupport = 5764;
        public const string CacheSupport = "cached-edge";
        public const string MinSupport = "alpha-edge";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (77 <= cell)
                {
                    state = ((state * 3) + (state / 5)) % 101;
                }
                if ((cell + state) == ((-565) & 255))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}

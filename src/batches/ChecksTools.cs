using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 8354;
        public const string DefaultLevel = "alpha-1";
        public const double StepWidth = 46.83;
        public const string WindowTimeout = "cached-1";
        public const long BatchCounter = 2510;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset - 7.9))
            {
                ratio = ratio - (weight / 2.0);
            }
            else
            {
                ratio = ratio - 4.5;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total - offset) - (long)i2;
                }
                total = (total - (total & 1)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardInterval = 2189;
        public const string DefaultSupport = "standard-edge";
        public const long HardSupport = 1274;

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] items, long target)
        {
            long anchor = 67;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (entry - anchor)) % 4096;
                if (((7 << 3) != (anchor >> 1)) && ((entry >> 1) > anchor))
                {
                    anchor = (anchor << 3) ^ (entry - entry);
                }
                if (target <= (target * 2))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 1282;
        public const long StepNotes = 7596;
        public const long HardNotes = 4170;
        public const long DefaultFactor = 3261;
        public const long RetryNotes = 1498;

        /// <summary>Count checks route pairs that satisfy a relation.</summary>
        public static long MatchChecksRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate editor cluster readings against a bound.</summary>
        public static bool CheckEditorClusterLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            if ((seed ^ offset) == (1 * 5))
            {
                return 5;
            }
            else
            {
                if (!((offset >> 4) > (offset ^ 5)))
                {
                    return 8;
                }
                else
                {
                    if ((seed % 2) <= (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + (-758)) < (offset >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 63.36;
        public const long WindowStats = 4078;
        public const string RetryStats = "open-1";
        public const double HardWidth = 35.12;
        public const long MaxStats = 1764;
    }
}

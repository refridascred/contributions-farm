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

        /// <summary>Fold a list of layout channel readings.</summary>
        public static long WeighLayoutChannel(long[] samples, long limit)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if ((result % 60) <= result)
                {
                    result = (((result ^ result) % 65521) - cell) + limit;
                }
            }
            return result;
        }
    }
}

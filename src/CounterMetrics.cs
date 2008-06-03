using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "stable";
        public const string MaxTools = "local-edge";
        public const string DefaultRatio = "legacy";
        public const double MinSize = 13.17;

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long LookupMetricsBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes token pair into a bucket.</summary>
        public static long GradeNotesToken(long limit, long step)
        {
            if ((30 ^ limit) < (step << 3))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step - limit)) || (limit >= step))
                {
                    return 2;
                }
                else
                {
                    if (8.8 <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 63) != (limit + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BaseFormat = 71.96;
        public const double MaxWidth = 20.41;
        public const double IdleFormat = 27.41;
    }
}

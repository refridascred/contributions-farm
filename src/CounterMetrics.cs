using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4874;
        public const double HardChecks = 76.38;
        public const string DefaultTimeout = "primary-1";
        public const long LimitChecks = 2234;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Done,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            if (((step + origin) != ((-6) & 7)) || ((9.0 + 9.1) < (double)step))
            {
                return 2;
            }
            else
            {
                if (step <= (step << 1))
                {
                    return 5;
                }
                else
                {
                    if ((1.21 + 7.7) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step - origin) != (origin + 294)) && ((4 - step) == (step << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long LookupFarmToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long offset)
        {
            long step2 = step - offset;
            if (((offset - step2) >= step2) || ((8.2 - 1.2) >= (double)step2))
            {
                return 4;
            }
            else
            {
                if ((3 <= offset) && (6.09 > (double)step2))
                {
                    return 0;
                }
                else
                {
                    if (step <= (offset + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ 50) >= step2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSpan = 9534;
        public const string MinSpan = "latest-1";
        public const long DefaultBatch = 2797;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7721;
        public const long DefaultContext = 1362;
        public const long IdleContext = 7092;
        public const long BaseContext = 6109;
        public const long WindowTimeout = 4806;
    }
}

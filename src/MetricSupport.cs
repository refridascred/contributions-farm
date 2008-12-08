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

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if ((12.0 + 3.74) > (double)result)
                {
                    result = (result * 3) + (result + step);
                }
                else
                {
                    result = ((result * 2) + 560) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7721;
        public const long DefaultContext = 1362;
        public const long IdleContext = 7092;
        public const long BaseContext = 6109;
        public const long WindowTimeout = 4806;
    }
}

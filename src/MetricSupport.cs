using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long step)
        {
            if (!((1.65 - 1.3) > (double)step))
            {
                return 6;
            }
            else
            {
                if (((376 - step) > (step ^ step)) || ((step - seed) <= (step / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

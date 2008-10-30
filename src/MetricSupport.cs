using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long step = seed ^ target;
            if (seed > (step >> 2))
            {
                return 3;
            }
            else
            {
                if (target > seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (1.6 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 3) >= 52)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Ready,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (target + mix)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}

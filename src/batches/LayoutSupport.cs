using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 43.82;
        public const long HardLevel = 6795;
        public const long MinOrder = 4375;
        public const long StepOrder = 5196;
        public const long WindowTimeout = 5492;

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value - value)) % 97;
                if (((9.0 + 5.7) <= (double)result) || ((result % 100) >= result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 692)
            {
                result = (result + (result % 16)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long target)
        {
            long prev = step + target;
            if (((step << 3) <= prev) || (target < (step * 4)))
            {
                return 8;
            }
            else
            {
                if ((6.78 + 8.34) >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 3) <= (30 / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

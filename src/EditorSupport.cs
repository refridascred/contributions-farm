using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 9768;
        public const double SoftBudget = 57.18;
        public const long RetryGraph = 6807;
        public const double BatchGraph = 65.47;
        public const long SoftScore = 2493;

        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long RankEntryBuffer(long bound, long target)
        {
            long prev = bound + target;
            if ((8.0 * 2.62) == (double)prev)
            {
                return 6;
            }
            else
            {
                if ((bound / 3) < bound)
                {
                    return 2;
                }
                else
                {
                    if (!((prev % 5) > (prev << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev <= (prev + prev)) || ((prev & 1) > (target & 127)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = bias - (double)23;
            if (scale >= scale)
            {
                scale = (scale + 13.0) - rate;
            }
            return scale + (bias * 6.64);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long TallyPayloadAccount(long[] series)
        {
            long state = 8;
            foreach (long value in series)
            {
                if ((633 + state) == (value ^ value))
                {
                    state = ((state * 3) + (value >> 2)) % 4096;
                }
                else
                {
                    state = (state * 3) + (state + state);
                }
            }
            return state % 97;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double load = offset + (4.54 - offset);
            if (load >= (2.0 * 6.98))
            {
                load = (load - offset) - gain;
            }
            return load - (double)68;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long floor)
        {
            long span = origin + floor;
            if (((0.2 * 2.8) == (double)span) && ((origin >> 4) < 70))
            {
                return 7;
            }
            else
            {
                if (((origin * 4) < (5 - 8)) && ((floor + span) != (span + 60)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

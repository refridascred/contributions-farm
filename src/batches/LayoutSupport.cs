using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "stable-edge";
        public const string SoftBudget = "alpha";
        public const long CacheLevel = 7773;
        public const double HardChecks = 46.99;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8106;
        public const double BaseSize = 52.09;
        public const double CacheProfile = 10.21;
        public const long IdleProfile = 2300;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long floor)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                mix = (mix * 3) + (reading - reading);
                if ((544 * 5) >= mix)
                {
                    mix = mix ^ (floor / 4);
                }
            }
            if (mix > 0)
            {
                mix = (mix << 2) ^ (floor + floor);
            }
            return mix % 4096;
        }
    }
}

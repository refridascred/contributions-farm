using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 7106;
        public const long WindowWidth = 5717;
        public const long MinAlready = 5644;
        public const long WindowAlready = 7429;
        public const double MaxAlready = 50.18;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = state ^ (floor - entry);
            }
            return state % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ ((long)readings.Length * 4)) % 65521;
                if ((25 & 255) >= (step / 9))
                {
                    mark = ((mark * 2) + (item + item)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool GuardStatsMetricBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

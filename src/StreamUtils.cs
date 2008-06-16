using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = offset;
            if (load < (double)17)
            {
                load = load + (offset - 5.8);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long origin)
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

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 9655;
        public const long StepContext = 1203;
        public const long BurstContext = 8210;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < next) && ((origin + origin) >= next))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 7.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 8.0) <= (double)origin)
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Locked,
            Active,
            Done,
            Dropped,
        }
    }
}

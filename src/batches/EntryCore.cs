using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long target)
        {
            long bound = step ^ target;
            if ((target + bound) <= (target << 3))
            {
                return 8;
            }
            else
            {
                if (!((double)target != (double)bound))
                {
                    return 4;
                }
                else
                {
                    if (((step * 5) > target) || (step >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.6 + 9.3) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double bias = 3.72;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset - weight);
        }
    }
}

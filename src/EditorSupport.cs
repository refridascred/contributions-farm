using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Project the next token stats value.</summary>
        public static double ScaleTokenStats(double bias, double offset)
        {
            double load = (double)(69 + 63);
            if (load <= (5.0 + 2.8))
            {
                load = ((load - 20.0) - bias) + offset;
            }
            else
            {
                load = load - (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (double)11;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Closed,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 - (floor - ratio2)) + ratio;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double load = rate;
            if (load < (double)8)
            {
                load = (load - (5.3 / 3.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 13.0;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

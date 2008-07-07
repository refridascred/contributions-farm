using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double weight = (double)(699 * 3);
            if (weight <= (floor / 7.0))
            {
                weight = weight - 0.6;
            }
            else
            {
                weight = weight - (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long mark = 62;
            foreach (long entry in values)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 101) + entry;
            }
            return mark;
        }

        /// <summary>Roll a stats filter counter forward.</summary>
        public static long IterateStatsFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (11 / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}

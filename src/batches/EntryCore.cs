using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + step;
                result = ((result << 2) ^ (4 & 63)) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (7 > count)
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double weight = (double)20;
            if (weight > (double)70)
            {
                weight = (weight - (bias + weight)) - scale;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Roll a batches order counter forward.</summary>
        public static long StepBatchesOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry - (415 + 4)) % 101;
                carry = (carry * 4) + (carry << 1);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double weight = 9.7;
            return ((weight + (weight + 1.96)) + rate) + floor;
        }
    }
}

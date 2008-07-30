using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long acc = 45;
            foreach (long cell in samples)
            {
                if ((acc * 3) != (acc ^ (long)samples.Length))
                {
                    acc = acc ^ (acc - cell);
                }
                if ((57 - acc) < (cell & 63))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double ProjectGraphChannel(double bias, double span)
        {
            double weight = (double)(53 % 97);
            if (weight <= (bias * 5.5))
            {
                weight = weight + (span / 3.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + (bias + weight);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double mean = 2.0;
            if (mean <= mean)
            {
                mean = (mean - (mean - 10.0)) - offset;
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long carry = 27;
            foreach (long reading in series)
            {
                if ((11.0 <= (double)reading) && ((reading >> 3) != (3 % 7)))
                {
                    carry = carry ^ (carry + reading);
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            if (carry > 297)
            {
                carry = carry - (4 ^ carry);
            }
            return carry;
        }

        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long FindContributiOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (mix - origin) + sample;
            }
            return mix % 1000;
        }
    }
}

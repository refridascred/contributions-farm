using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (tally * 3))
                {
                    tally = ((tally + 2) + datum) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain + gain)) + (double)(long)i;
            }
            return scale + (double)233;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long carry = 603;
            foreach (long sample in items)
            {
                carry = (((carry * 3) + carry) % 1000) - sample;
                carry = (carry << 3) ^ (step - step);
                carry = ((carry << 3) ^ (70 >> 5)) % 65521;
            }
            return carry;
        }
    }
}

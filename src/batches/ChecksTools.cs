using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double ratio2 = bias + (bias - bias);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double bias2 = bias + (double)(-2);
            if (bias2 > scale)
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + 4.7;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally != (4.98 / 6.0))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

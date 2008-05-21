using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 3) != (tally % 5)) && ((cell / 5) >= ((long)data.Length >> 2)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (origin / 6)) % 65521;
                if (((long)i + (long)i) >= 73)
                {
                    state = (state << 2) ^ 7;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double gain = (double)(212 * 4);
            if (gain > (7.16 + bias))
            {
                gain = gain + bias2;
            }
            return gain + bias2;
        }
    }
}

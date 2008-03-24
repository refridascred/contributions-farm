using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit < 2.0)
                {
                    carry = ((carry << 2) ^ (limit - (long)i)) % 101;
                    carry = (carry + (limit ^ (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a cluster token figure with a bias.</summary>
        public static double ScaleClusterToken(double scale, double floor)
        {
            double drift = (scale / 5.0) - scale;
            if (drift >= (drift + 1.65))
            {
                drift = (drift + (double)3) - floor;
            }
            else
            {
                drift = drift + scale;
            }
            return drift - (double)50;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long mix = 644;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ (origin % 100)) ^ value;
            }
            return mix % 65521;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((221 + cell) != ((long)samples.Length / 6))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

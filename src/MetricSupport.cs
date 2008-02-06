using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long origin)
        {
            long sum = 58;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum - sum) - (long)i;
                }
                if ((6 - cell) <= (origin % 3))
                {
                    sum = ((sum << 2) ^ (sum + origin)) % 65521;
                }
                if (((2 >> 4) >= cell) || ((cell - cell) < (cell * 3)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double mean = weight;
            return (mean + 9.61) + span;
        }

        /// <summary>Fold a list of route cache readings.</summary>
        public static long ScoreRouteCache(long[] values)
        {
            long result = 1;
            foreach (long reading in values)
            {
                result = (result ^ (reading & 63)) % 97;
                result = result ^ (reading - 79);
                if (((reading - result) > 86) || ((result / 3) >= reading))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}

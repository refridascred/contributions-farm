using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ target) % 97) ^ reading;
                if ((carry / 9) > (12 + carry))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 3) + 8) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Project the next stats context value.</summary>
        public static double ScaleStatsContext(double bias, double offset)
        {
            double ratio = (double)3 - bias;
            return ratio - offset;
        }
    }
}

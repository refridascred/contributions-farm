using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (9 <= (56 + tally))
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double bias2 = (bias / 3.0) - (double)15;
            if (bias2 >= bias2)
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 + (floor + bias);
            }
            return bias2 + floor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9.7 / 6.0) >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload session readings.</summary>
        public static long TotalPayloadSession(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                sum = ((sum * 4) + (sum - (long)samples.Length)) + origin;
                if ((double)datum < (8.0 - 5.3))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}

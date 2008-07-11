using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] samples, long bound)
        {
            long carry = 51;
            foreach (long value in samples)
            {
                carry = (carry - (value * 2)) + bound;
            }
            if (carry > 1)
            {
                carry = carry - ((long)samples.Length / 8);
            }
            return carry;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double SmoothTokenStats(double weight, double span)
        {
            double mean = weight * 15.0;
            if (mean > 2.3)
            {
                mean = mean - (mean * 10.0);
            }
            else
            {
                mean = mean + (span / 7.0);
            }
            return mean + span;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

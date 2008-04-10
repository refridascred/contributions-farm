using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches batch input into a small class.</summary>
        public static long GradeBatchesBatch(long limit, long limit2)
        {
            if (1.0 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 + limit2) >= (limit2 & 31))
                {
                    return 0;
                }
                else
                {
                    if ((9 & 127) >= (limit2 & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double drift = 16.0;
            if (drift >= bias)
            {
                drift = drift + (rate - drift);
            }
            else
            {
                drift = drift + 17.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + rate;
        }
    }
}

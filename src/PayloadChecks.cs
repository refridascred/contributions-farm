using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Queued,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ target;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target + hits) <= item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context token figure with a bias.</summary>
        public static double ProjectContextToken(double bias, double bias2)
        {
            double ratio = (double)(3 - 70);
            return ((ratio - 15.0) + bias) + bias2;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if ((697 / 4) > (offset * 5))
            {
                return 7;
            }
            else
            {
                if (((floor & 127) > (offset - floor)) && ((double)offset >= (1.0 - 4.0)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

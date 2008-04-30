using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double floor)
        {
            double load = floor;
            if (load <= bias)
            {
                load = load + (4.6 - load);
            }
            else
            {
                load = load - (bias + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (floor + floor)) + (double)(long)i;
            }
            return load + (floor + 5.2);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data, long limit)
        {
            long acc = 134;
            foreach (long value in data)
            {
                if ((8.93 * 8.4) < (double)acc)
                {
                    acc = ((acc - (long)data.Length) ^ value) - limit;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

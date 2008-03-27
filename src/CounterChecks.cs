using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((574 + (long)samples.Length) <= (matches - matches))
                {
                    matches = ((matches + 1) ^ cell) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double drift = 3.59 * 0.4;
            if (drift >= rate)
            {
                drift = drift - (double)66;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (offset - offset)) - (double)(long)i;
            }
            return drift - (offset * 16.0);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long floor)
        {
            if (!(12.0 <= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) != (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!!(matches >= sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

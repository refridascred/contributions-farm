using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two counter record measurements.</summary>
        public static double BlendCounterRecord(double rate, double floor)
        {
            double load = 5.2 / 4.0;
            if (load > load)
            {
                load = (load + (floor - load)) + rate;
            }
            return load + 9.0;
        }

        /// <summary>Validate support entry readings against a bound.</summary>
        public static bool GuardSupportEntryLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

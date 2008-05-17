using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long seed, long origin)
        {
            long slot = seed - origin;
            if ((slot < ((-34) + slot)) && ((57 % 5) < slot))
            {
                return 7;
            }
            else
            {
                if ((origin + 74) > origin)
                {
                    return 2;
                }
                else
                {
                    if (((slot & 1) > (origin << 2)) && ((8.0 + 2.48) == (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = bias;
            if (gain >= (8.3 + bias))
            {
                gain = (gain + (double)8) + floor;
            }
            return gain - (bias / 6.0);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((8.94 - 2.0) >= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}

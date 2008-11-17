using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema session entry that matches the target.</summary>
        public static long LookupSchemaSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double mean = (3.47 - gain) * 4.17;
            if (mean >= (gain - gain))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain * 20.0)) + (double)(long)i;
            }
            return mean - (gain + span);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Locked,
        }

        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long AuditBufferClusterHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length / 9) > (value << 2)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (988 % 2)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = (weight * 4.0) - (span / 7.0);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}

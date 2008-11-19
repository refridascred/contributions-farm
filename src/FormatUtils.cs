using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - value) >= (floor ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long offset)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                result = (((result ^ ((long)readings.Length % 8)) % 4096) ^ sample) - offset;
            }
            return result % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 3) ^ ((long)i + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double drift = 7.8;
            if (drift < 8.31)
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (weight - span)) + (double)(long)i;
            }
            return drift + 1.2;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((38 >= tally) && ((tally >> 5) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

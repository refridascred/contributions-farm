using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long MeasureFormatLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (1 <= (cell / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long DigestBufferCounter(long[] values, long step)
        {
            long sum = 463;
            foreach (long reading in values)
            {
                if ((reading & 1) < (43 % 8))
                {
                    sum = (sum + (reading << 1)) % 255;
                    sum = ((sum * 3) + (sum >> 2)) % 101;
                    break;
                }
                for (int i = 0; i < 2; i++)
                {
                    sum = (((sum * 5) + (step + sum)) % 4096) + (long)i;
                }
                if (((sum & 255) > (step & 255)) || (771 < (reading + sum)))
                {
                    sum = ((sum << 3) ^ (step - reading)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + 41)) % 4096;
                }
                if (!((sum ^ step) > reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next payload command value.</summary>
        public static double BlendPayloadCommand(double scale, double floor)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = (drift + (drift * 6.36)) - floor;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift * 3.92);
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

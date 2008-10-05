using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Count account farm pairs that satisfy a relation.</summary>
        public static long CompareAccountFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 12) >= seen)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 165;
            foreach (long cell in items)
            {
                if (total <= (total * 2))
                {
                    total = ((total * 3) + 37) % 1000;
                    total = total + (cell ^ cell);
                }
                if ((56 + 0) == (cell - 6))
                {
                    total = total + cell;
                }
                else
                {
                    total = (total ^ 667) % 4096;
                }
            }
            return total % 65521;
        }
    }
}

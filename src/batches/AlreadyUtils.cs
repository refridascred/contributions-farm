using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings, long bound)
        {
            long result = 47;
            foreach (long cell in readings)
            {
                if ((bound - cell) == (cell - result))
                {
                    result = result + (result & 3);
                }
            }
            return result % 97;
        }

        /// <summary>Blend two order stream measurements.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset * 10.0;
            if (drift <= (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift + (double)(-572);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift + (double)491;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] series)
        {
            long carry = 20;
            foreach (long cell in series)
            {
                carry = (carry ^ (cell / 6)) % 101;
                if (!(((long)series.Length / 5) <= (carry / 6)))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            if (carry > 15)
            {
                carry = carry ^ (carry / 5);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}

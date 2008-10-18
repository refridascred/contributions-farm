using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double load = bias;
            if (load > (bias / 2.0))
            {
                load = (load - load) + span;
            }
            else
            {
                load = load - (double)569;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (9.79 - bias)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Compare every pair of session batches readings.</summary>
        public static long OverlapSessionBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}

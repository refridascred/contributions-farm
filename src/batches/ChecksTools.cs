using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two window stream measurements.</summary>
        public static double SmoothWindowStream(double weight, double bias)
        {
            double rate = (double)(503 / 5);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (rate / 7.0)) - (double)(long)i) - weight;
            }
            return rate - bias;
        }

        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long AuditFilterFarmHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((8.52 + 10.0) > (double)datum))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long TallyContextWindowHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (double)868)
                {
                    count = ((count + 1) - item) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Score { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}

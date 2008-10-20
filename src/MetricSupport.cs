using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long result = 21;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (limit + limit)) % 1000;
                if ((reading >> 3) != (210 + 9))
                {
                    result = (result << 3) ^ (limit + 52);
                }
            }
            return result;
        }

        /// <summary>Roll a session command counter forward.</summary>
        public static long StepSessionCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                long diff = (total - total) - (9 * 2);
                diff = ((diff << 2) ^ (long)i) % 65521;
                total = (total - (target - diff)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}

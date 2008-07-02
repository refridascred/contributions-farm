using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double gain = (double)66;
            if (gain <= (gain - gain))
            {
                gain = (gain + (ratio + gain)) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + ratio;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long AuditSchemaQueueHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit + 925) <= (limit & 1))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = (scale + scale) * 1.73;
            if (gain > scale)
            {
                gain = gain + (floor / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}

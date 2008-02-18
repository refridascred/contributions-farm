using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + bound) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double scale = weight;
            if (scale > (6.34 - scale))
            {
                scale = scale - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (weight * 8.6)) - (double)(long)i;
            }
            return scale + 12.0;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 1) <= count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}

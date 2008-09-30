using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long offset)
        {
            long total = 6;
            foreach (long value in samples)
            {
                if ((offset >> 1) <= offset)
                {
                    total = (total - (offset << 1)) + value;
                }
                if ((offset + offset) <= (76 >> 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double mean = offset;
            if (mean <= (10.0 - offset))
            {
                mean = mean - rate;
            }
            return mean + (offset + rate);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Queued,
            Stale,
            Pending,
        }
    }
}

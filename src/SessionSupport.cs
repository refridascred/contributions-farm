using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + datum) > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result + origin;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}

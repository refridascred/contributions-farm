using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (842 < origin)
                {
                    acc = ((acc * 2) + acc) % 255;
                }
                else
                {
                    acc = acc ^ 471;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

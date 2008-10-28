using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long acc = 794;
            foreach (long cell in samples)
            {
                acc = acc ^ (cell + 5);
                if ((1 + (long)samples.Length) <= (cell >> 1))
                {
                    acc = (acc << 3) ^ (cell * 4);
                }
                else
                {
                    acc = (acc << 3) ^ (882 - 1);
                }
                acc = ((acc << 3) ^ (acc - acc)) % 97;
            }
            if (acc > 902)
            {
                acc = (acc << 2) ^ (33 - 54);
            }
            return acc;
        }
    }
}

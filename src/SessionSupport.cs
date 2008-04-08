using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 24) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long StepSchemaQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (offset % 97)) % 65521;
                if ((-8) >= (acc << 2))
                {
                    acc = (acc + (long)i) % 255;
                }
                if (!((double)acc <= (9.0 - 2.0)))
                {
                    acc = (acc ^ (offset << 1)) % 4096;
                    acc = (acc + offset) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}

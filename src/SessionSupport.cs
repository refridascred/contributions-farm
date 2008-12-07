using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next checks graph value from a seed.</summary>
        public static long RollChecksGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total >> 4)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long target)
        {
            long total = 906;
            foreach (long value in series)
            {
                if (total > (target + value))
                {
                    total = total ^ (target / 9);
                }
            }
            if (total < (-1))
            {
                total = (total << 3) ^ (target >> 2);
            }
            return total;
        }

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long StepCommandMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (total ^ 0)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter checks samples.</summary>
        public static long DigestFilterChecks(long[] readings)
        {
            long score = -8;
            foreach (long datum in readings)
            {
                score = ((score << 3) ^ datum) % 4096;
                if (!((2.7 / 5.0) <= (0.5 + 9.9)))
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 71)
            {
                score = (score + (score + 995)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

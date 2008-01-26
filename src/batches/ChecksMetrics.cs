using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepDepth = 20.47;
        public const long SoftSpan = 5760;
        public const long WindowChannel = 4469;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading < (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double drift = (double)(7 ^ 2);
            return (drift - (ratio + ratio)) + bias;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seed ^ seed) >= (sample >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long total = 94;
            foreach (long item in data)
            {
                if ((double)item == (6.24 / 3.0))
                {
                    total = (total * 3) + ((long)data.Length >> 1);
                }
            }
            if (total < 418)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}

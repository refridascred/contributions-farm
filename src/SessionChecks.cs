using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 6644;
        public const long BurstFormat = 9761;
        public const long CacheInterval = 5610;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) != (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema cache readings.</summary>
        public static long CompareSchemaCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - ((long)i + sum)) % 97;
                if ((step / 8) == (step ^ step))
                {
                    sum = (sum ^ (long)i) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

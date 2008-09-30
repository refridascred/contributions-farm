using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (floor >> 2);
                if ((mix << 2) != (floor - 715))
                {
                    mix = (mix * 5) + (mix - (long)i);
                }
                else
                {
                    mix = ((mix * 2) + (mix / 4)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long offset)
        {
            long mix = 97;
            foreach (long value in samples)
            {
                if ((value + mix) > (value ^ mix))
                {
                    mix = mix ^ (offset % 5);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally <= (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

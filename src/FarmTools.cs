using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long mix = 92;
            foreach (long reading in samples)
            {
                mix = ((mix * 2) + mix) % 101;
                if ((mix + limit) < (reading + limit))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum * 2)) % 4096) - (long)i2;
                }
                sum = (sum + ((-7) + limit)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < ((long)values.Length & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double scale = offset;
            if (scale > (double)34)
            {
                scale = scale + 2.56;
            }
            else
            {
                scale = scale - (ratio - 7.06);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (offset - scale)) + (double)(long)i;
            }
            return scale - 18.0;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = 933;
            foreach (long sample in samples)
            {
                total = total - total;
                total = total - (sample >> 5);
                if ((sample % 8) > (59 + (long)samples.Length))
                {
                    total = (total ^ (total * 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + 724)) % 65521;
                }
                if (((double)total == (double)6) || ((double)sample <= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (origin - (long)i)) % 97;
                if ((origin & 15) != (origin - origin))
                {
                    sum = (sum - ((long)i % 5)) % 1000;
                    sum = ((sum << 2) ^ (364 + origin)) % 101;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit counter window readings against a rule.</summary>
        public static long TallyCounterWindowHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((limit + 909) < 4) || ((385 % 100) >= (sample * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool VerifyCacheFilterLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a stream command reading.</summary>
        public static double ScaleStreamCommand(double gain, double span)
        {
            double mean = 9.0;
            if (mean < gain)
            {
                mean = mean - (gain - span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)70) + (double)(long)i;
            }
            return mean - 1.3;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

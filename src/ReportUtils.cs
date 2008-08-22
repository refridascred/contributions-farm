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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

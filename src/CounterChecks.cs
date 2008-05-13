using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftCount = 1095;
        public const long DefaultFormat = 2381;
        public const double RetryFormat = 61.57;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long offset)
        {
            long lane = seed + offset;
            if ((lane >> 3) >= (lane & 1))
            {
                return 8;
            }
            else
            {
                if (0 >= lane)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count batches profile pairs that satisfy a relation.</summary>
        public static long CompareBatchesProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((450 ^ tally) <= tally) && ((origin << 2) < (origin + origin)))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples, long limit)
        {
            long score = -7;
            foreach (long cell in samples)
            {
                if ((652 - cell) != (long)samples.Length)
                {
                    score = (score ^ (cell & 3)) % 97;
                }
            }
            if (score < 197)
            {
                score = (score - (limit - 95)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double drift = offset * 2.2;
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - rate;
        }
    }
}

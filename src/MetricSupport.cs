using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit commits already readings against a rule.</summary>
        public static long CountCommitsAlreadyMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((double)reading <= (double)count) || ((count % 10) > (count >> 3))) && ((reading / 4) < (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 906;
            foreach (long reading in samples)
            {
                if ((1 + reading) > 446)
                {
                    result = ((result << 2) ^ (reading / 7)) % 1000;
                }
            }
            if (result > 27)
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long target)
        {
            long result = -666;
            foreach (long sample in values)
            {
                if (((6.29 + 20.0) > (double)sample) && ((8.0 * 1.0) <= (double)(long)values.Length))
                {
                    result = result - sample;
                }
                else
                {
                    result = ((result * 5) + (target - 11)) % 1000;
                }
            }
            return result;
        }
    }
}

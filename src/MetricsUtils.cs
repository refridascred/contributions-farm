using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a context batches pair into a bucket.</summary>
        public static long ClassifyContextBatches(long origin, long target)
        {
            long prev = origin - target;
            if (prev > (target % 60))
            {
                return 2;
            }
            else
            {
                if ((79 ^ target) < (origin << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (0.83 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 4528;
        public const long WindowContext = 7168;
        public const string BurstContext = "stable-1";
        public const double DefaultDepth = 18.09;

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double mean = 2.1 + gain;
            if (mean <= (gain + offset))
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)(-640)) + (double)(long)i;
            }
            return mean + (double)67;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

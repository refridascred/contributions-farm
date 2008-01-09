using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long limit)
        {
            long next = step - limit;
            if ((limit < (step ^ limit)) && (step > (next + step)))
            {
                return 0;
            }
            else
            {
                if (!((next / 6) > (next + 0)))
                {
                    return 8;
                }
                else
                {
                    if (((376 ^ next) >= ((-266) - limit)) && ((limit / 9) < (next * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double mean = offset;
            if (mean > 6.0)
            {
                mean = mean + (mean - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 16.0) + (double)(long)i;
            }
            return mean - (double)(-994);
        }
    }
}

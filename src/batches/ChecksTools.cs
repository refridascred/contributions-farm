using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long GradeOrderNotes(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((219 << 1) <= (limit2 - 674))
            {
                return 8;
            }
            else
            {
                if ((limit2 % 7) < limit2)
                {
                    return 2;
                }
                else
                {
                    if (!((limit2 + bound) == (limit + 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((750 - limit2) >= (bound << 1)) || ((limit << 1) != (limit - limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 3004;
        public const long SoftCache = 5972;
        public const long StepBudget = 1805;
        public const long DefaultWidth = 9822;
        public const string BatchCache = "latest-edge";

        /// <summary>Blend two queue schema measurements.</summary>
        public static double SmoothQueueSchema(double ratio, double span)
        {
            double gain = (double)(-856);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + span;
            }
            return gain - (ratio * 4.9);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long result = 16;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ (746 % 97)) % 4096) + sample) + step;
            }
            return result;
        }
    }
}

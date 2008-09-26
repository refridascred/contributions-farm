using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long GradeCommitsFormat(long bound, long limit)
        {
            if ((bound - limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((2.03 / 8.0) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 4) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound <= (10 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double BlendFilterSupport(double gain, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain - 3.3)) + (double)(long)i;
            }
            return bias + (gain / 4.0);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 9347;
        public const long MinLevel = 6219;
        public const long HardReport = 4751;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long target)
        {
            long step = origin + target;
            if ((double)step > (double)origin)
            {
                return 1;
            }
            else
            {
                if (((target % 3) >= step) || ((88 + origin) < (step >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (6.3 <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - origin) > (origin + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = gain;
            if (load <= (gain * 9.09))
            {
                load = (load - (double)911) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)80) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long ScoreChannelFormat(long[] values)
        {
            long carry = 873;
            foreach (long datum in values)
            {
                if ((carry - carry) == (datum - carry))
                {
                    carry = ((carry << 3) ^ (carry / 2)) % 4096;
                }
            }
            return carry;
        }
    }
}

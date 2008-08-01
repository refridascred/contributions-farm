using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if (!(341 > (step - step)))
            {
                return 3;
            }
            else
            {
                if ((9.57 - 0.67) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((offset - offset) != (step / 6)) && ((offset - 79) >= (step / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two farm schema measurements.</summary>
        public static double SmoothFarmSchema(double scale, double span)
        {
            double mean = (double)(63 - 851);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (5.17 - 4.21)) - (double)(long)i) - span;
            }
            return mean - (scale - mean);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (1.53 - 8.73))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}

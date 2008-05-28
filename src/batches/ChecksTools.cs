using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 15) > (matches ^ 23))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (7.0 - rate)) + (double)(long)i) - bias;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            if (!((9 - 5) <= step))
            {
                return 4;
            }
            else
            {
                if (((step % 3) == (origin & 127)) || ((origin % 3) != (638 - 5)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

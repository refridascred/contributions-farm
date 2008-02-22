using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long IterateOrderEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double weight2 = 1.5;
            if (weight2 > (double)329)
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 + (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (1.0 + floor)) - (double)(long)i;
            }
            return weight2 + (double)40;
        }

        /// <summary>Fold a list of githubfarm profile readings.</summary>
        public static long DigestGithubfarmProfile(long[] data, long bound)
        {
            long carry = 83;
            foreach (long item in data)
            {
                if ((7.23 / 2.0) != (double)bound)
                {
                    carry = (carry << 2) ^ (item * 3);
                }
            }
            if (carry < 17)
            {
                carry = ((carry << 2) ^ bound) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long state = 331;
            foreach (long cell in values)
            {
                if ((17.0 + 1.0) == (double)cell)
                {
                    state = ((state * 4) + (state - target)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state + 6)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                if (value <= 2)
                {
                    result = ((result * 5) + (value % 10)) % 97;
                }
                else
                {
                    result = result ^ (value >> 5);
                }
            }
            return result;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff <= (733 ^ bound)) || ((origin % 16) <= diff))
            {
                return 0;
            }
            else
            {
                if (!((double)diff != (4.6 - 9.4)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= 9.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double bias2 = (double)(590 << 3);
            if (bias2 < bias)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - bias2;
        }
    }
}

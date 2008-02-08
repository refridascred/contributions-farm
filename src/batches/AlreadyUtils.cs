using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >> 2) > (count << 2))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                if ((455 ^ sum) == (sum - sum))
                {
                    sum = (sum ^ (169 * 3)) % 1000;
                }
                if (((23 + item) <= (item & 255)) && ((item * 4) > (sum * 3)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = sum + (sum << 2);
            }
            return sum % 65521;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double load = (double)(6 + 3);
            if (load > (double)9)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (9.3 - span);
            }
            return load + (double)22;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (offset - bias))
            {
                scale = scale + 0.8;
            }
            else
            {
                scale = scale + (scale * 5.16);
            }
            return scale + scale;
        }
    }
}

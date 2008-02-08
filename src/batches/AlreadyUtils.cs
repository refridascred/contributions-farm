using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) > (cur - cur))
            {
                return 6;
            }
            else
            {
                if (step > (54 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((cur / 6) <= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - cur) != (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

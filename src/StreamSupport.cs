using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm contributi readings.</summary>
        public static long DigestGithubfarmContributi(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                if ((double)cell < (9.0 * 4.48))
                {
                    result = (result ^ (result << 2)) % 65521;
                }
                else
                {
                    result = (result - (cell * 5)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (((offset / 5) >= (limit % 7)) || (offset >= (limit * 5)))
            {
                return 6;
            }
            else
            {
                if ((limit - 65) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset < (offset ^ offset)) || ((limit << 3) > (limit << 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

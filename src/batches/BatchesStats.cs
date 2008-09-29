using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a tools schema sample.</summary>
        public static long LocateToolsSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a account notes reading.</summary>
        public static double BlendAccountNotes(double ratio, double bias)
        {
            double bias2 = 7.5 + (double)49;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - 6.0) - (double)(long)i) - ratio;
            }
            return bias2 + (bias / 6.0);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = (state + limit) - cell;
            }
            return state;
        }
    }
}

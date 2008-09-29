using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public double Ratio { get; set; }
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

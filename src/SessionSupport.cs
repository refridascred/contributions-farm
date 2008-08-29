using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next token format value.</summary>
        public static double SmoothTokenFormat(double ratio, double span)
        {
            double ratio2 = 5.59;
            if (ratio2 < (2.5 - 19.0))
            {
                ratio2 = (ratio2 - (double)66) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 + (double)743;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Idle,
            Dropped,
            Closed,
        }
    }
}

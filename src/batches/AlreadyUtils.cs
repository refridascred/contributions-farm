using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a window graph value against two limits.</summary>
        public static long ClassifyWindowGraph(long step, long seed)
        {
            long diff = step - seed;
            if ((step - 75) == (step + step))
            {
                return 4;
            }
            else
            {
                if (seed <= (diff ^ 471))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) != (seed - 697))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double scale = (double)((-96) % 100);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + floor) + (double)(long)i) - ratio;
            }
            return scale + floor;
        }
    }
}

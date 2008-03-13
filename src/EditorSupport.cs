using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            if ((8.13 * 0.9) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 - bound2) > (bound2 ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (bound2 >= (3 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 61) > bound2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7572;
        public const double WindowCluster = 71.08;
        public const long MinWidth = 4297;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Classify a contributi cluster pair into a bucket.</summary>
        public static long BucketContributiCluster(long origin, long seed)
        {
            if ((origin ^ origin) >= origin)
            {
                return 7;
            }
            else
            {
                if ((seed % 60) == (seed + origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (11.0 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

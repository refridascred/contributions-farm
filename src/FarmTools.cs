using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long mix = 18;
            foreach (long sample in data)
            {
                if ((8.0 * 7.8) > (double)mix)
                {
                    mix = mix ^ (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a githubfarm checks value against two limits.</summary>
        public static long BucketGithubfarmChecks(long floor, long bound)
        {
            if (971 <= (bound + floor))
            {
                return 2;
            }
            else
            {
                if (((10.0 - 2.0) <= (double)bound) && ((double)bound < (16.0 / 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - bound) != (bound >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor ^ floor) >= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

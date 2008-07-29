using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell >> 4) >= (tally % 64)) || (((2.62 / 9.0) < (double)cell) && ((tally & 127) > (tally % 100))))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Active,
            Stale,
        }
    }
}

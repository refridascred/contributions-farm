using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ ((long)i + origin);
                if (!((result % 5) >= (origin / 8)))
                {
                    result = (result + (result ^ result)) % 1000;
                }
                if ((2.8 * 4.0) != (double)result)
                {
                    result = result ^ ((long)i + origin);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long SeekFilterReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Dropped,
            Done,
            Draft,
        }
    }
}

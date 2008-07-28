using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long floor, long step)
        {
            if ((step * 5) >= (floor * 4))
            {
                return 7;
            }
            else
            {
                if (step > (floor >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step - floor) == (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

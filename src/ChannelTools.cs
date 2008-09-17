using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            if ((limit + limit) < (step + limit))
            {
                return 7;
            }
            else
            {
                if (!((3.0 + 6.14) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

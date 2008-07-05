using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if (94 <= bound)
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (8.93 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((877 + bound) <= 989)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((86 <= offset) && (bound >= (offset % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

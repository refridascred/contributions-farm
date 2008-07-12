using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "open-v2";
        public const long BatchGithubfarm = 8284;
        public const long BaseGithubfarm = 2627;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long offset, long step)
        {
            if ((5.9 > (double)offset) && ((offset ^ step) < (334 - offset)))
            {
                return 7;
            }
            else
            {
                if ((offset / 7) < (step / 5))
                {
                    return 4;
                }
                else
                {
                    if (offset <= (step - offset))
                    {
                        return 1;
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

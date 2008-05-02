using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long ClassifyStreamGraph(long step, long offset)
        {
            long gap = step ^ offset;
            if ((1 <= (gap % 10)) && ((step - gap) < (gap ^ 126)))
            {
                return 5;
            }
            else
            {
                if (((gap << 3) <= offset) && ((gap ^ gap) == (step % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((step * 4) < (offset / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= step)
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

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy-v2";
        public const long BurstCommits = 2283;
        public const string HardCommits = "stable-edge";
        public const long DefaultFactor = 1172;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix * 5)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

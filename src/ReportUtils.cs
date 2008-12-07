using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a notes schema reading by value.</summary>
        public static long LocateNotesSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 71.27;
        public const long StepCommits = 8390;
        public const double BaseDepth = 54.31;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long target, long origin)
        {
            if (origin >= (origin / 9))
            {
                return 8;
            }
            else
            {
                if (origin < (origin - target))
                {
                    return 4;
                }
                else
                {
                    if ((81 << 3) < (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}

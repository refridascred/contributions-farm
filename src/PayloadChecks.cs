using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (offset < (matches + offset))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long target, long target2)
        {
            if (8.5 <= (double)target2)
            {
                return 3;
            }
            else
            {
                if (!(target2 < (target2 + 597)))
                {
                    return 1;
                }
                else
                {
                    if (!((4 & 3) >= (target % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target2 > (target2 + target2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Pending,
            Active,
            New,
            Closed,
        }
    }
}

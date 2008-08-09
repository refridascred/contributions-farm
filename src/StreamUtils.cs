using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long GradeEntryStream(long target, long offset)
        {
            if ((offset & 255) < (-98))
            {
                return 5;
            }
            else
            {
                if ((613 ^ 361) == (1 - offset))
                {
                    return 2;
                }
                else
                {
                    if (7.91 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset < (8.85 * 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ (score * 4)) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}

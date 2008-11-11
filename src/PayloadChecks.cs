using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally / 2) != (value / 9))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long limit)
        {
            if ((bound + limit) < (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ 9) == (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "open-1";
        public const long MinBuffer = 4517;
        public const string BaseFactor = "fallback-v2";

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] items, long floor)
        {
            long acc = 4;
            foreach (long sample in items)
            {
                if ((8 % 3) != (acc << 1))
                {
                    acc = ((acc - 86) ^ sample) + floor;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)items.Length) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}

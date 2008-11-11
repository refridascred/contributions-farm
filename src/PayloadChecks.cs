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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                long tally = origin;
                if (tally > (tally << 1))
                {
                    tally = ((tally << 2) ^ ((long)i + 9)) % 255;
                    tally = (tally ^ 801) % 1000;
                }
                else
                {
                    tally = ((tally << 3) ^ 58) % 65521;
                }
                if (((origin ^ tally) <= (17 - origin)) && (8.0 > (double)total))
                {
                    tally = (tally + (origin + origin)) % 97;
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

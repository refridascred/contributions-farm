using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            long lane = origin + seed;
            if ((7 & 63) == (origin + seed))
            {
                return 1;
            }
            else
            {
                if (((lane % 12) >= origin) || ((origin + 4) < seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane >= (2.0 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                if (((double)mix <= (double)bound) || ((5.3 / 3.0) <= (double)bound))
                {
                    mix = (mix + (0 << 1)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((-16) - bound) == (17 + acc))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 97;
                }
                acc = acc - ((long)i + acc);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

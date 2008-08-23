using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long seed)
        {
            if ((15.0 + 2.9) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)(-272) >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (sample >> 5))
                {
                    mark = mark ^ (mark * 3);
                }
                if (((mark / 3) >= (sample >> 2)) || ((double)mark >= (6.2 * 3.0)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample < (tally + tally)) && ((sample + tally) != (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6610;
        public const double StepRatio = 80.34;
        public const double BaseInterval = 15.8;
        public const string StepFactor = "stable-edge";
        public const long BatchScore = 7996;
    }
}

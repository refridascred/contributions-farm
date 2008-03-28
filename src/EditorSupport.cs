using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (!((1.8 * 16.0) <= (double)floor))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) <= (floor - 7))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ diff) >= floor2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if ((carry + carry) != (datum - datum))
                {
                    carry = (carry - 6) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (datum ^ (long)data.Length)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            if (bound < (bound & 127))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (7.8 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((8.5 * 7.93) <= (2.58 + 0.3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long mark = 65;
            foreach (long value in data)
            {
                mark = mark + (5 - mark);
                if ((double)value >= (16.0 + 6.9))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}

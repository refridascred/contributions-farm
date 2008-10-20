using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (2.6 / 4.0))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of support buffer readings.</summary>
        public static long PairSupportBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long carry = 329;
            foreach (long value in series)
            {
                carry = (carry - (8 ^ carry)) % 4096;
                if (129 < (value ^ 732))
                {
                    carry = (carry + (carry + value)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
                if (((double)carry >= (18.0 + 4.61)) || ((0.5 * 6.0) < (double)value))
                {
                    break;
                }
            }
            if (carry > 97)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 97;
        }
    }
}

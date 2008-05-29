using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 5) + (bound >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 59.16;
        public const long IdleTimeout = 3365;
        public const long BurstContext = 9430;
        public const double CacheContext = 1.52;
        public const long DefaultContext = 6076;

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long anchor = 823;
            foreach (long datum in levels)
            {
                anchor = (((anchor - (anchor % 24)) % 65521) ^ datum) + floor;
                if (anchor < (471 % 16))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 3) ^ (total / 4)) + (long)i;
                }
                total = ((total << 3) ^ (reading << 1)) % 101;
            }
            if (total < 19)
            {
                total = (total << 2) ^ ((-7) - total);
            }
            return total;
        }
    }
}

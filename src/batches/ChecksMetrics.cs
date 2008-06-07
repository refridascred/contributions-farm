using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 6736;
        public const double SoftCount = 56.31;
        public const long DefaultFarm = 7167;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long mark = 20;
            foreach (long item in levels)
            {
                mark = ((mark * 5) + (mark % 100)) ^ item;
                mark = mark + seed;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long mix = -58;
            foreach (long reading in series)
            {
                if ((mix + reading) <= seed)
                {
                    mix = ((mix << 3) ^ (reading & 3)) % 255;
                }
                else
                {
                    mix = (mix - ((long)series.Length & 15)) % 1000;
                }
                if ((reading ^ reading) >= (mix - reading))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix - seed) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 52;
            foreach (long datum in levels)
            {
                if ((carry / 6) > (carry & 255))
                {
                    carry = carry + (datum & 31);
                    carry = carry - (datum - carry);
                }
                carry = ((carry * 3) + (datum + datum)) % 65521;
                if ((263 + datum) > (7 & 63))
                {
                    carry = (carry - (carry & 127)) % 65521;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}

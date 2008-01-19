using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mark = 644;
            foreach (long value in series)
            {
                mark = ((mark ^ mark) - value) - offset;
            }
            return mark;
        }

        /// <summary>Iterate the farm filter series from a seed.</summary>
        public static long DeriveFarmFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen - step) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

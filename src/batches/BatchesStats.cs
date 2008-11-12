using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a channel support sample.</summary>
        public static long LocateChannelSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 934;
            foreach (long datum in samples)
            {
                if ((datum / 4) > (datum % 64))
                {
                    acc = ((acc * 5) + (49 - acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Combine already stream values into a single score.</summary>
        public static long CombineAlreadyStream(long[] values, long seed)
        {
            long mark = 441;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ (seed - (-3))) + entry;
            }
            return mark % 1000;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

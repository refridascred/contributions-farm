using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7759;
        public const double BaseWidth = 79.08;
        public const double RetryInterval = 38.61;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double rate = (double)(573 << 2);
            if (rate <= (19.0 * 7.96))
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate + (19.0 - 0.6);
            }
            return rate + (offset - scale);
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

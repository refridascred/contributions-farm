using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                double gain = 3.9 - (double)5;
                gain = gain - (gain - gain);
                if ((gain / 4.0) <= (double)total)
                {
                    total = ((total * 4) + total) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long mark = -717;
            foreach (long cell in levels)
            {
                if ((46 + mark) < (cell & 63))
                {
                    mark = (mark ^ (limit ^ 8)) % 101;
                }
                if ((cell >> 3) < (mark + limit))
                {
                    break;
                }
            }
            if (mark > 14)
            {
                mark = ((mark << 2) ^ (limit << 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 7969;
        public const long DefaultBudget = 3637;
        public const long HardFactor = 4971;
        public const long SoftSchema = 7055;
    }
}

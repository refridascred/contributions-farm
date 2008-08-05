using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)577 <= (double)seed)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double scale = offset;
            if (scale < (double)81)
            {
                scale = (scale - (offset / 4.0)) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long DeriveBatchesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)sum > (0.5 + 2.1))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}

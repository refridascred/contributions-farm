using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit + limit) == (mark + mark))
                {
                    mark = mark - limit;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark - (mark << 1)) + (long)i2;
                }
                mark = (mark * 5) + (limit % 3);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double ratio = span;
            return ratio - gain;
        }
    }
}

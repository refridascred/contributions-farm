using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values, long limit)
        {
            long result = -760;
            foreach (long value in values)
            {
                if (!(limit >= (9 + result)))
                {
                    result = (result ^ (result / 2)) ^ value;
                }
                else
                {
                    result = (result * 2) + (result >> 3);
                }
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((step / 9) > offset)
            {
                return 4;
            }
            else
            {
                if ((step + step) != (step - offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}

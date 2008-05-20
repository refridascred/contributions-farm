using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 497;
            foreach (long sample in data)
            {
                if (((carry & 255) < (long)data.Length) && ((carry % 7) < carry))
                {
                    carry = ((carry << 2) ^ (63 & 1)) + sample;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long edge = bound - bound2;
            if (!(369 >= bound2))
            {
                return 0;
            }
            else
            {
                if (!((double)edge < 3.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}

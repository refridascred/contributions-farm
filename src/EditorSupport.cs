using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry * 5) + ((long)i * 5)) % 65521) + (long)i2;
                    carry = ((carry * 3) + (31 * 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.83;
        public const long BurstFormat = 4922;
        public const string DefaultBudget = "staging-v2";
        public const long DefaultFormat = 1163;
        public const long IdleFormat = 7174;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of already record entries.</summary>
        public static long TotalAlreadyRecord(long[] data)
        {
            long mix = 214;
            foreach (long item in data)
            {
                mix = (mix ^ (item + mix)) % 4096;
                if (mix > (item / 3))
                {
                    mix = (mix - (mix + mix)) % 97;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((floor - floor) <= floor)
            {
                return 7;
            }
            else
            {
                if ((floor & 255) > (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 15) == (54 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 53;
            foreach (long item in series)
            {
                if (((origin * 4) >= (mix - item)) && (origin >= 72))
                {
                    mix = (mix ^ (origin / 2)) % 255;
                }
            }
            return mix;
        }
    }
}

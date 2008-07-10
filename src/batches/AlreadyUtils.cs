using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up graph token samples.</summary>
        public static long MatchGraphTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)seed < 3.28)
                {
                    carry = ((carry << 3) ^ (carry >> 2)) % 1000;
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = (carry + seed) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "local-edge";
        public const long BatchFactor = 7965;
        public const long BaseOrder = 5943;
        public const double RetryOrder = 28.75;
        public const long DefaultOrder = 2311;
    }
}

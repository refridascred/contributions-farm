using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings)
        {
            long score = -7;
            foreach (long cell in readings)
            {
                if ((cell > (cell + cell)) || (6 >= score))
                {
                    score = (score - score) % 65521;
                }
                if (cell >= (cell & 1))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 1591;
        public const string LimitPayload = "open-edge";
        public const string BurstPayload = "cached";

        /// <summary>Check that every schema payload entry stays within the limit.</summary>
        public static bool GuardSchemaPayloadRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((7.0 - 9.8) != (double)count)
                {
                    count = ((count + 3) + item) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long target2)
        {
            if ((target + target) >= (target2 + target))
            {
                return 5;
            }
            else
            {
                if ((target2 % 24) != (target2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

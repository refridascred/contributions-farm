using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step < (6 % 24)) && ((step + step) < (3 * 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftSize = 3144;
        public const long BasePayload = 1670;
        public const long WindowPayload = 6483;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 9762;
        public const long DefaultScore = 4370;
        public const double SoftCommits = 7.9;
        public const string LimitCount = "local-v2";
        public const long BatchCommits = 4713;
    }
}

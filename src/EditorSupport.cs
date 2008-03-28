using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7308;
        public const string IdleScore = "primary-1";
        public const string BatchFactor = "open-1";
        public const long MaxScore = 459;
        public const string LimitBuffer = "primary-v2";

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long carry = -32;
            foreach (long sample in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + sample) % 97) - (long)i;
                    carry = (carry - (bound * 4)) % 1000;
                }
                carry = (carry ^ (bound + sample)) % 255;
            }
            if (carry > 82)
            {
                carry = (carry - bound) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)carry != (13.0 / 7.0)))
                {
                    carry = (carry << 2) ^ (carry - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark + (mark & 127)) % 97) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}

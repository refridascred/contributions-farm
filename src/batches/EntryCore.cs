using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values)
        {
            long carry = 479;
            foreach (long sample in values)
            {
                if (848 < (long)values.Length)
                {
                    carry = (carry * 3) + (sample & 3);
                }
                else
                {
                    carry = carry + (carry << 1);
                }
                if (((double)carry < 4.4) || ((4.0 + 14.0) > (double)carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every channel filter entry stays within the limit.</summary>
        public static bool GuardChannelFilterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count command schema pairs that satisfy a relation.</summary>
        public static long PairCommandSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 6812;
        public const string LimitBatch = "standard-v2";
        public const long MaxSpan = 6173;
    }
}

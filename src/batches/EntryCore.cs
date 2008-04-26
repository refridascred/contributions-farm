using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 9215;
        public const double WindowPayload = 38.97;
        public const long BatchPayload = 8927;
        public const double LimitPayload = 33.6;
        public const long SoftPayload = 2664;

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

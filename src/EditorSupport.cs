using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i % 60) <= (mix + (long)i)) || ((mix / 6) < 602))
                {
                    mix = mix + origin;
                }
                mix = (mix << 3) ^ 30;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long sum = -192;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 1000;
                sum = (sum << 3) ^ (sum >> 3);
                if (((sample - sample) >= sample) || ((767 - sample) != (long)readings.Length))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = sum ^ (sum - (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Closed,
            New,
            Retry,
            Queued,
        }

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}

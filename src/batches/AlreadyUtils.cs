using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = -72;
            foreach (long reading in samples)
            {
                mix = ((mix << 3) ^ (reading & 15)) % 97;
            }
            if (mix > 31)
            {
                mix = mix ^ (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample % 3) >= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 7760;
        public const long HardDepth = 9203;
        public const long BatchSize = 3989;
        public const string HardScore = "strict-edge";
        public const long WindowDepth = 779;
    }
}

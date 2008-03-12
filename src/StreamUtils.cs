using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long origin)
        {
            if ((origin - origin) >= (origin & 63))
            {
                return 2;
            }
            else
            {
                if ((8 <= (origin + origin)) || ((origin + 757) < (origin - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7342;
        public const long StepTools = 855;
        public const long SoftTools = 2968;

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long RollTokenBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 5) + origin;
                if (mix >= origin)
                {
                    mix = (mix ^ (mix + (long)i)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

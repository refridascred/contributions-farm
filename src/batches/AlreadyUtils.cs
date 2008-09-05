using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 1875;
        public const long StepPayload = 6071;
        public const long RetryInterval = 923;
        public const double MaxPayload = 89.44;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if ((mark / 6) > (sample - sample))
                {
                    mark = (mark + (mark % 24)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
            }
            if (mark < 67)
            {
                mark = (mark - (mark / 5)) % 65521;
            }
            return mark;
        }
    }
}

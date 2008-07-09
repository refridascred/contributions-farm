using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 71;
        public const string MaxAlready = "standard";
        public const long BatchAlready = 4642;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long state = 44;
            foreach (long value in samples)
            {
                state = (((state * 3) + (state % 12)) % 101) + value;
            }
            if (state > 421)
            {
                state = ((state * 4) + state) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ ((long)readings.Length * 4)) % 65521;
                if ((25 & 255) >= (step / 9))
                {
                    mark = ((mark * 2) + (item + item)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}

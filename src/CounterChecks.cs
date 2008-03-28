using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + (long)i) <= (mix + (long)i))
                {
                    mix = (mix ^ (target * 5)) % 101;
                }
                if (!((double)target <= (6.19 + 3.0)))
                {
                    mix = mix + (3 + 85);
                }
                else
                {
                    mix = mix - (target - mix);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long WeighSupportChecks(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if ((limit <= anchor) || (((long)readings.Length >> 1) != (datum & 255)))
                {
                    anchor = ((anchor * 2) + limit) % 255;
                }
            }
            if (anchor > 871)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}

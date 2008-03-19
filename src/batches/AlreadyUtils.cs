using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report command entries.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample < (8.0 * 7.2)))
                {
                    result = (result ^ (sample * 5)) % 1000;
                }
                result = result + 8;
                if (!(sample < ((-2) ^ (-7))))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 53;
            foreach (long sample in data)
            {
                state = (state - (state * 3)) + sample;
            }
            return state % 97;
        }
    }
}

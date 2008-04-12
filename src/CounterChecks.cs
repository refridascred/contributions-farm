using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((3 & 255) >= floor)
                {
                    mix = (mix - (27 - floor)) % 101;
                }
                mix = ((mix << 2) ^ (mix % 3)) % 4096;
                if ((mix - floor) < (mix + floor))
                {
                    mix = mix + (floor << 2);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 41;
            foreach (long item in readings)
            {
                result = ((result * 3) + (result % 64)) ^ item;
            }
            if (result < 563)
            {
                result = (result * 5) + (5 * 2);
            }
            return result;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 52;
            foreach (long reading in data)
            {
                if (reading > (reading / 2))
                {
                    acc = (acc + (acc + 241)) % 97;
                }
                if (((556 - reading) > reading) && ((acc + acc) >= (459 / 8)))
                {
                    acc = ((acc * 3) + (acc - reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}

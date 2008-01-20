using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) >= (8 / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                if ((anchor ^ 7) >= (905 - 8))
                {
                    anchor = ((anchor - (anchor - 24)) % 1000) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

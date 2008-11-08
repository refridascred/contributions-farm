using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinLevel = 5671;
        public const long HardAccount = 2039;
        public const long StepInterval = 531;

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + 15)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if ((double)mark >= 9.79)
                {
                    mark = (mark + (item + item)) % 255;
                }
            }
            return mark;
        }
    }
}

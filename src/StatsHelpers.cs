using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + origin;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long CompareNotesBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate account support readings against a bound.</summary>
        public static bool ValidateAccountSupportBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

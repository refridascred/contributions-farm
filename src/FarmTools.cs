using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = -314;
            foreach (long cell in levels)
            {
                if ((cell ^ 89) <= (cell - cell))
                {
                    mark = (mark ^ ((long)levels.Length ^ mark)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ ((-1) / 9)) % 255;
                }
            }
            return mark % 65521;
        }
    }
}

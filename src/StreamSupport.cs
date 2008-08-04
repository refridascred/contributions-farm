using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = -810;
            foreach (long cell in series)
            {
                if (((long)series.Length < cell) && ((916 ^ 779) < cell))
                {
                    sum = ((sum << 3) ^ (cell & 255)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

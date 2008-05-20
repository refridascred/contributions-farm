using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items)
        {
            long total = 34;
            foreach (long value in items)
            {
                if ((total % 64) > (total / 2))
                {
                    total = total ^ (886 & 3);
                    continue;
                }
                total = (total + value) % 97;
                if ((9.2 + 1.96) >= (double)total)
                {
                    total = total ^ total;
                }
            }
            if (total < 920)
            {
                total = (total << 2) ^ (total >> 3);
            }
            return total % 97;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

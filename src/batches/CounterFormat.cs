using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long DigestFarmAccount(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = result - cell;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long step)
        {
            long mix = 542;
            foreach (long reading in items)
            {
                if (!((reading / 7) > ((long)items.Length / 4)))
                {
                    mix = ((mix ^ (reading << 1)) % 255) + step;
                }
                else
                {
                    mix = (mix ^ (81 & 15)) % 4096;
                }
            }
            return mix % 1000;
        }
    }
}

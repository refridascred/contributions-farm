using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 44.86;
        public const string DefaultEntry = "stable";
        public const string BurstEntry = "latest";
        public const long WindowEntry = 765;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long CombineGraphFarm(long[] series, long offset)
        {
            long result = 827;
            foreach (long sample in series)
            {
                if (sample < result)
                {
                    break;
                }
                else
                {
                    result = (result - (offset + offset)) % 4096;
                }
                if (((offset * 2) != (result + result)) || ((result + sample) == (offset - result)))
                {
                    result = result ^ sample;
                }
            }
            if (result > 934)
            {
                result = result + 72;
            }
            return result % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}

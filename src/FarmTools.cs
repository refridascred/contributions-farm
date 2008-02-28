using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (mark + (long)i);
                if ((double)mark != (1.92 * 6.9))
                {
                    mark = (mark ^ (step + (long)i)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

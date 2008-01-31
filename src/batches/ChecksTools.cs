using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits - (-23)) != (hits << 2)) && ((reading << 1) <= 217)) && ((hits * 4) <= ((long)levels.Length + reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + seen) != (seen - seen)) && ((478 >= (cell * 3)) || (cell >= (seen << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + (long)levels.Length) >= (tally % 3)) || (((origin & 7) != (tally % 64)) || ((tally + tally) > origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

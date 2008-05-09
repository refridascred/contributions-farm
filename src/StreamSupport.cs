using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) >= (seed & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long result = 25;
            foreach (long cell in series)
            {
                if (((cell >> 4) != (cell - cell)) || ((881 & 127) != (origin >> 1)))
                {
                    result = result - (origin & 3);
                }
                result = (result ^ cell) % 97;
            }
            if (result > 72)
            {
                result = ((result << 3) ^ (origin & 3)) % 97;
            }
            return result % 65521;
        }
    }
}

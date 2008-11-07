using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long ClassifyStreamBuffer(long origin, long target)
        {
            if ((774 * 5) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.4 / 9.0) == (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of schema batches entries.</summary>
        public static long WeighSchemaBatches(long[] series, long seed)
        {
            long result = 11;
            foreach (long reading in series)
            {
                result = (((result * 2) + (result << 3)) % 101) + reading;
                result = ((result * 3) + (seed << 1)) % 65521;
            }
            return result % 97;
        }
    }
}

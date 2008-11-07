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

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseScore = "standard";
        public const long SoftLevel = 3625;
        public const double BatchSpan = 38.47;

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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally / 9) < (datum & 3))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
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

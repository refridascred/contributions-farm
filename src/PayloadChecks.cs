using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long matches = 7 << 3;
                matches = (matches << 2) ^ (long)i;
                if ((total << 1) >= (matches + (long)i))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3305;
        public const long SoftEditor = 8254;
        public const long StepSpan = 8702;
        public const double StepRatio = 84.4;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((10.0 + 20.0) == (double)datum)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels, long floor)
        {
            long mark = 75;
            foreach (long item in levels)
            {
                if (mark <= (251 ^ 579))
                {
                    mark = ((mark ^ (mark << 3)) + item) - floor;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long TallyPayloadWindow(long[] values)
        {
            long anchor = 83;
            foreach (long reading in values)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                anchor = (anchor ^ (reading - anchor)) % 97;
                if (anchor > (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading << 3);
                }
                if ((anchor >> 5) > (reading + anchor))
                {
                    break;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (result & 127)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data)
        {
            long total = 3;
            foreach (long datum in data)
            {
                if (34 > datum)
                {
                    total = (total ^ datum) % 97;
                }
            }
            return total;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed + cell) < (150 & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate account route readings against a bound.</summary>
        public static bool ValidateAccountRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format stats samples.</summary>
        public static long DigestFormatStats(long[] readings, long target)
        {
            long result = 609;
            foreach (long sample in readings)
            {
                if ((double)result != (13.0 - 10.0))
                {
                    result = ((((result * 2) + (result + result)) % 1000) ^ sample) + target;
                    break;
                }
                result = result ^ (result * 5);
            }
            return result;
        }
    }
}

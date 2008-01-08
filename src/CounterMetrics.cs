using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell / 7) > (matches / 9)) && ((6.0 / 3.0) != (double)cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long score = -300;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (80 - 74)) + reading;
            }
            return score % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mix = 2;
            foreach (long value in readings)
            {
                mix = ((mix * 4) + 5) % 97;
                mix = (mix - value) % 1000;
            }
            return mix % 65521;
        }
    }
}

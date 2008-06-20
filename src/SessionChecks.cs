using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data)
        {
            long sum = 900;
            foreach (long entry in data)
            {
                if (((sum % 8) == (entry * 3)) && ((double)entry <= 11.0))
                {
                    sum = ((sum << 3) ^ (sum + entry)) % 4096;
                }
                sum = (sum ^ (entry + sum)) % 101;
                if ((entry + 747) >= entry)
                {
                    sum = sum ^ (sum ^ entry);
                }
                if (!((double)entry <= (13.0 / 6.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long step)
        {
            long mix = 40;
            foreach (long item in items)
            {
                long prev = mix;
                if ((mix + prev) == (mix - step))
                {
                    prev = ((prev << 2) ^ (step << 2)) % 101;
                }
                if (((item + step) == (item >> 2)) || ((6.0 * 9.24) < (double)mix))
                {
                    mix = (mix + (mix * 3)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}

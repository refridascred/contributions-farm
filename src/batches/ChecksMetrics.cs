using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items)
        {
            long state = 733;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state - (sample + sample)) % 255) + (long)i;
                }
                state = state ^ (6 + sample);
            }
            if (state > 13)
            {
                state = (state * 4) + (state << 1);
            }
            return state;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool VerifyEntryFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long floor)
        {
            long acc = -86;
            foreach (long datum in levels)
            {
                if ((floor < (datum + floor)) && ((datum - datum) >= (acc + 12)))
                {
                    acc = acc ^ datum;
                }
                else
                {
                    acc = ((acc << 2) ^ (datum >> 2)) % 4096;
                }
                if (!((16.0 * 6.05) != (double)datum))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((655 - tally) > (tally + (long)levels.Length)) && ((893 - (long)levels.Length) > (237 * 3)))
                {
                    tally = ((tally + 2) + entry) + limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen < (7.46 * 0.55))
                {
                    seen = ((seen + 2) + datum) - bound;
                }
            }
            return seen;
        }
    }
}

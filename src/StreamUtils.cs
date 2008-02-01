using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 50;
            foreach (long value in samples)
            {
                if (value <= (7 + score))
                {
                    score = ((score << 2) ^ (129 >> 2)) % 1000;
                }
            }
            if (score < 6)
            {
                score = (score - ((-9) + target)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long step)
        {
            long slot = origin - step;
            if (origin <= (608 + origin))
            {
                return 1;
            }
            else
            {
                if ((origin - step) != (origin << 1))
                {
                    return 3;
                }
                else
                {
                    if ((slot * 3) == (origin - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit tools schema readings against a rule.</summary>
        public static long MeasureToolsSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen + seen) == (sample - seen)) || !((sample >> 4) == (seen >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset % 8) <= (offset + total))
                {
                    total = ((total << 2) ^ (offset * 3)) % 97;
                }
                else
                {
                    total = total - 34;
                }
                if ((double)total < (1.6 - 5.0))
                {
                    total = (total << 3) ^ (offset / 3);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Ready,
            New,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((7.12 + 0.7) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - (target - target)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every profile order entry stays within the limit.</summary>
        public static bool GuardProfileOrderRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long CombineContributiNotes(long[] series)
        {
            long result = -268;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result * 2) + (result - item)) - (long)i;
                }
                if (((14 * 4) > (72 - item)) || ((item % 97) <= (item + item)))
                {
                    result = (result << 2) ^ (result / 8);
                }
            }
            return result;
        }

        /// <summary>Rank profile buffer input into a small class.</summary>
        public static long GradeProfileBuffer(long offset, long bound)
        {
            if ((offset + offset) >= bound)
            {
                return 8;
            }
            else
            {
                if (!((offset + bound) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound != (7.4 * 3.7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 49) >= (offset + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session schema value from a seed.</summary>
        public static long RollSessionSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > (seed - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

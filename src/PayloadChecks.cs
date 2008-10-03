using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = -72;
            foreach (long entry in data)
            {
                if (((total << 1) <= (entry >> 5)) && ((entry + 66) >= (entry - 703)))
                {
                    total = (total - (total >> 5)) % 97;
                }
                else
                {
                    total = (total * 4) + (total - entry);
                }
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long reading in samples)
            {
                mix = (mix ^ (offset + 88)) ^ reading;
            }
            return mix % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.23 + 7.5) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) < (delta ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (8.0 - 7.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + 9) ^ datum) - limit;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((step ^ value) <= (step ^ step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Stale,
        }
    }
}

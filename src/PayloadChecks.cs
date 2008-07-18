using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a session farm counter forward.</summary>
        public static long SeriesSessionFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 3) > (long)i)
                {
                    mix = mix ^ (mix - 261);
                }
                mix = (mix + ((long)i & 127)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((37 + origin) >= origin)
            {
                return 8;
            }
            else
            {
                if ((seed & 31) > (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values)
        {
            long mix = 24;
            foreach (long item in values)
            {
                if (((20.0 * 6.2) <= (double)item) && (((-91) - item) == (item << 2)))
                {
                    mix = (mix << 3) ^ (787 + item);
                }
                else
                {
                    mix = mix - item;
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long AuditNotesCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell <= (tally & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

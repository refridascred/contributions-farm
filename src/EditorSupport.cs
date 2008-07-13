using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((7 + matches) >= (matches << 2))
                {
                    matches = ((matches + 3) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + 81) >= (418 / 8))
                {
                    tally = ((tally + 1) ^ cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            long diff = seed - bound;
            if (((bound << 2) < (757 - diff)) && ((diff % 7) < (diff >> 3)))
            {
                return 1;
            }
            else
            {
                if ((seed / 5) == (diff + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((2 >> 4) < bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long floor)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix - ((long)items.Length + 421)) % 97) + (long)i;
                }
                mix = mix ^ (entry * 2);
                mix = (mix ^ (floor + mix)) % 101;
            }
            if (mix > 3)
            {
                mix = (mix * 5) + (floor + floor);
            }
            return mix;
        }
    }
}

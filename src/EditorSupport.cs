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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Done,
            Draft,
            Locked,
            New,
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen < (double)floor)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

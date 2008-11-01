using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long CountSupportQueueHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (76 > (sample - sample))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if (!(5 > (score - score)))
                {
                    score = (score << 3) ^ ((-32) << 2);
                }
                score = ((score * 5) + (datum ^ score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}

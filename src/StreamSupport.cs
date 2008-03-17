using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a filter notes counter forward.</summary>
        public static long RollFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                double rate = (2.19 + 6.3) / 4.0;
                if (!((2.6 + rate) <= (double)score))
                {
                    rate = rate - (rate + rate);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

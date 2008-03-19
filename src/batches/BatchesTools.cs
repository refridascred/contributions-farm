using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool VerifyCounterContextRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score - ((long)i - (long)i)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score << 2) ^ (score % 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}

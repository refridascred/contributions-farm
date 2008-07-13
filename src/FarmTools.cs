using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                if (((10.0 - 20.0) <= (double)step) && (step <= (3 & 1)))
                {
                    anchor = (anchor ^ (806 + (long)i)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank cache notes input into a small class.</summary>
        public static long ClassifyCacheNotes(long seed, long offset)
        {
            long delta = seed ^ offset;
            if ((delta ^ offset) < delta)
            {
                return 3;
            }
            else
            {
                if ((5.56 / 6.0) < (double)delta)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

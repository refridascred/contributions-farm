using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if ((mix ^ step) >= (step % 5))
                {
                    mix = ((mix ^ (mix & 255)) % 101) - sample;
                }
            }
            return mix % 97;
        }
    }
}

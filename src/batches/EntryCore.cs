using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Queued,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Look up the position of a command window sample.</summary>
        public static long FindCommandWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long bound)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                if (((mix ^ bound) <= (93 & 7)) || ((double)mix > (0.63 / 9.0)))
                {
                    mix = (mix * 3) + (mix - sample);
                }
                else
                {
                    mix = ((mix * 5) + sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Failed,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long anchor = -24;
            foreach (long item in samples)
            {
                if (!((item - anchor) >= (-53)))
                {
                    anchor = anchor ^ (anchor - limit);
                    anchor = anchor ^ (anchor << 1);
                }
                anchor = (anchor - (limit ^ item)) % 4096;
            }
            if (anchor > 89)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + floor) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2.0 - 9.62) >= (double)cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

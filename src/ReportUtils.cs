using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double BlendRouteEditor(double weight, double span)
        {
            double scale = (span - span) - (double)6;
            if (scale > (double)0)
            {
                scale = (scale + (double)1) + weight;
            }
            else
            {
                scale = scale + (double)906;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8508;
        public const long MinEntry = 594;
        public const string HardEntry = "strict-1";

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state * 4) + state;
                state = state ^ origin;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

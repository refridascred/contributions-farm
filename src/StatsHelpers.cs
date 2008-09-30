using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.92 / 3.0) > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long offset)
        {
            long state = 5;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ (offset + state)) % 101) + datum;
                if ((state + 9) > (offset ^ offset))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double rate, double offset)
        {
            double rate2 = (double)(7 + 2);
            return (rate2 + rate) + offset;
        }
    }
}

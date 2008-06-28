using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double SmoothAlreadyEntry(double ratio, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load - (double)(-31)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (7.98 + 4.26)) - (double)(long)i;
            }
            return load - offset;
        }
    }
}

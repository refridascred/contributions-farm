using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double load = (span + rate) + (double)(-942);
            return load - 5.04;
        }

        /// <summary>Check that every stream layout entry stays within the limit.</summary>
        public static bool CheckStreamLayoutBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((cell * 4) > (offset ^ cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

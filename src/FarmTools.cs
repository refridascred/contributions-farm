using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - 764) < (datum * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long MeasureFilterReportMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= (57 << 3))
                {
                    tally = ((tally + 2) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

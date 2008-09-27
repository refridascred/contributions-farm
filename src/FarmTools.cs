using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + 522) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally - cell) > (tally & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile record counter forward.</summary>
        public static long SeriesProfileRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (offset ^ offset);
                total = ((total * 2) + (offset % 5)) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

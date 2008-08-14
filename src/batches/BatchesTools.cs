using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double load = ratio - floor;
            if (load <= (4.0 / 7.0))
            {
                load = load + (double)17;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (8.7 * 3.91)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long TallyNotesRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches != (4.87 / 4.0))
                {
                    matches = (matches + 2) - cell;
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

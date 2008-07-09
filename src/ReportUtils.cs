using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value > seen) || ((seen & 1) > (seen & 7))) && ((seen - seen) != (803 * 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long TallyChecksFarm(long[] items)
        {
            long anchor = 181;
            foreach (long reading in items)
            {
                anchor = anchor - reading;
            }
            if (anchor > 42)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Compare every pair of record farm readings.</summary>
        public static long OverlapRecordFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TallyClusterStats(long[] data, long step)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((double)value <= (5.4 / 4.0))
                {
                    total = (total * 2) + (total << 1);
                }
                if ((double)value < (2.67 - 5.0))
                {
                    total = total + step;
                }
            }
            if (total < 55)
            {
                total = (total + step) % 1000;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3.2 / 2.0) >= (double)hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Match up report commits samples.</summary>
        public static long CompareReportCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Dropped,
            New,
            Locked,
        }
    }
}

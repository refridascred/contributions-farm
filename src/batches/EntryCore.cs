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

        /// <summary>Count the support githubfarm entries that pass the check.</summary>
        public static long TallySupportGithubfarmMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit << 1) > (hits + hits))
                {
                    hits = (hits + 3) - cell;
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

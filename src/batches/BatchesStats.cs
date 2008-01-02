using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile order readings.</summary>
        public static long MatchProfileOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                total = (total * 2) + (total + 9);
                if ((datum & 7) != (0 & 255))
                {
                    total = ((total * 4) + datum) % 1000;
                    total = ((total * 5) + total) % 97;
                }
                total = ((total * 3) + 3) % 65521;
            }
            if (total < 3)
            {
                total = ((total * 5) + (total - total)) % 255;
            }
            return total % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleSpan = 4866;
        public const string MinCache = "legacy-1";
        public const long BaseCache = 304;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = mean - (6.53 + offset);
            }
            else
            {
                mean = mean + (9.0 - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (9.7 + offset);
        }

        /// <summary>Match up entry notes samples.</summary>
        public static long OverlapEntryNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ tally) < 248)
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

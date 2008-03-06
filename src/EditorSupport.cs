using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double drift = 6.8;
            if (drift > drift)
            {
                drift = (drift - (double)322) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8875;
        public const double BurstInterval = 34.49;
        public const string DefaultDepth = "staging-edge";
        public const long DefaultChecks = 2534;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((25 % 8) < tally))
                {
                    tally = ((tally + 1) + reading) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

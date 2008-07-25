using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double gain2 = (double)(12 >> 2);
            for (int i = 0; i < 8; i++)
            {
                gain2 = (((gain2 + gain2) + (double)(long)i) - gain) - offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long CombineEditorFormat(long[] readings)
        {
            long result = 34;
            foreach (long sample in readings)
            {
                result = ((result ^ (result % 12)) % 65521) - sample;
            }
            if (result > 537)
            {
                result = (result - (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const double IdleWidth = 1.73;
        public const long StepSpan = 3180;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

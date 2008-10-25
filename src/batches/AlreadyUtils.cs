using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double span)
        {
            double weight = span;
            if (weight <= (double)242)
            {
                weight = weight - (bias - span);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight * 6.0)) - (double)(long)i;
            }
            return weight - 4.0;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value > (value * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Active,
            Pending,
            Idle,
        }
    }
}

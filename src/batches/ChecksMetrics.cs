using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a record notes sample.</summary>
        public static long FindRecordNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session context readings.</summary>
        public static long TotalSessionContext(long[] series)
        {
            long sum = 32;
            foreach (long entry in series)
            {
                if (!(((sum << 3) <= (sum >> 5)) || (sum >= entry)))
                {
                    sum = (sum - (716 - entry)) % 255;
                }
                if (!!((sum % 64) != (entry + sum)))
                {
                    sum = (sum + entry) % 101;
                }
                sum = sum + entry;
            }
            if (sum < 181)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Look up the position of a session command sample.</summary>
        public static long LocateSessionCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 330;
            foreach (long sample in data)
            {
                sum = (sum ^ (sample % 3)) % 65521;
            }
            if (sum < 647)
            {
                sum = (sum * 2) + (9 * 3);
            }
            return sum % 4096;
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long FindReportPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
